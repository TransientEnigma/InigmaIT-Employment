using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.Configuration;
using System.IO;

//using ClassControlLib; -> class lib 

///This class uses the ado.net sql classes to provide a connection to an Azure sql server database.
///it is free for use by anybody so long as you give credit to the original author i.e me
///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019


//This file has been modified by Janzeb Masiano. The file was originally intended for Azure connection only
//I added code to use StreamReader to return a connection string stored in a text file on the desktop (this is more secure than hard coding the connection string)
//I added try catch, so if no string is returned for Azure, the program will default to local database
//I did not write the code in the catch statement, this was taken from the clsDataConnection class by Matthew Dean.
//I added extra comments to help me understand the code

public class clsDataConnection
{
    //connection object used to connect to the database
    SqlConnection connectionToDB = new SqlConnection();
    //data adapter used to transfer data to and from the database
    SqlDataAdapter dataChannel = new SqlDataAdapter();
    //ado.net class for building the sql commands    
    SqlCommandBuilder commandBuilder = new SqlCommandBuilder();
    //stores a list of all of the sql parameters
    List<SqlParameter> SQLParams = new List<SqlParameter>();
    //data table used to store the results of the stored procedure
    DataTable dataTable = new DataTable();
    //string variable used to store the connection string
    private string connectionString;

    public clsDataConnection()
    {
        GetConnectionString(GetDBName());
    }

    public clsDataConnection(string DBLocation)
    {
        GetConnectionString(DBLocation);
    }


    private string GetConnectionString(string SomePath)
    {

        //string to store connection string
        connectionString = "";
        //TRY TO CONNECT TO REMOTE AZURE DATABASE USING CONNECTION STRING SPECIFIED BY PATH FILE
        try
        {
            // Open the text file using a stream reader.
            using (StreamReader stringReader = new StreamReader(@"C:\Users\E-eng\Desktop\AzureConnectionString.txt"))
            {

                //Instantiate a StreamReader to read from the text file.
                connectionString = stringReader.ReadToEnd();
                //get rid of preceeding and following spaces

                //return the connection string
                return connectionString;
            }

        }
        //REMOTE CONNECTION FAILS SO WILL TRY AND CONNECT TO LOCAL DB
        catch
        {
            //build up the connection string for the sql server database Visual Studio 2010
            //connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=" + GetDBName() + ";Integrated Security=True;User Instance=True";
            //build up the connection string for the sql server database Visual Studio 2012
            //connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + GetDBName() + ";Integrated Security=True;Connect Timeout=30";
            //connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + GetDBName() + "\";Integrated Security=True;Connect Timeout=30";
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"###\";Integrated Security=True;Connect Timeout=30";
            //replaces the text ### for the DBPath
            connectionString = connectionString.Replace("###", SomePath);
            return connectionString;
        }

    }


    public string GetDBName()
    {

        //array to store folder names
        string[] filePaths;
        //var to store index for path array
        Int32 PathArrayIndex = 0;
        string[] dirConts;
        //flag for found
        Boolean Found = false;
        //var for counter
        Int32 Counter;
        List<string> DBNames = new List<string>();
        //get the folder for the project
        string BaseDir = TrimPath(System.AppDomain.CurrentDomain.BaseDirectory);
        do
        {
            //get the list of files in the folder (BaseDir) this is the directory the visual studio resides
            //(STEP 1) here we are simply getting the list of all the filepaths that are within that directory
            filePaths = System.IO.Directory.GetDirectories(BaseDir);
            PathArrayIndex = 0;
            while (PathArrayIndex < filePaths.Length & Found == false)
            {
                //make path lowercase
                filePaths[PathArrayIndex] = filePaths[PathArrayIndex].ToLower();
                //(STEP 2) make sure the file path contains the name app_data
                //(STEP 3) if the filepath contains the app_data then 
                if (filePaths[PathArrayIndex].Contains("app_data") == true)
                {
                    //(STEP 4) get the list of files in the app_data folder with extension .mdf
                    dirConts = System.IO.Directory.GetFiles(filePaths[PathArrayIndex], "*.mdf", System.IO.SearchOption.AllDirectories);
                    Counter = 0;
                    //while there are files to process
                    while (Counter < dirConts.Length)
                    {
                        //if the file is not a system database file
                        if (dirConts[Counter].Contains("ASPNETDB.MDF") == false)
                        {
                            //add the file to the list of db names
                            DBNames.Add(dirConts[Counter]);
                        }
                        //inc the counter
                        Counter++;
                    }
                    if (DBNames.Count == 1)
                    {
                        //flag found
                        Found = true;
                    }
                    else
                    {
                        //inc the counter
                        PathArrayIndex++;
                    }
                }
                else
                {
                    //inc the counter
                    PathArrayIndex++;
                }
            }
            if (Found == false)
            {
                //move up a path and try again
                BaseDir = TrimPath(BaseDir);
            }
        }
        while (BaseDir != "" & Found == false);
        //if one database name is found use that
        if (DBNames.Count == 1)
        {
            //return the full path of the db
            return DBNames[0];
        }
        //if no database is founjd throw an exception
        else if (DBNames.Count == 0)
        {
            throw new System.Exception("There is no database in your App_Data folder");
        }
        //if multiple database have been found throw an error
        else
        {
            throw new System.Exception("You have too many database files in your App_Data folder");
        }
    }

    private string TrimPath(string OldPath)
    {
        Int32 Posn = 0;
        //find the right most instance of \\
        Posn = OldPath.LastIndexOf("\\");
        if (Posn != -1)
        {
            //split the path at that point
            OldPath = OldPath.Substring(0, Posn);
        }
        else
        {
            OldPath = "";
        }
        return OldPath;
    }

    public void AddParameter(string ParamName, object ParamValue)
    ///public method allowing the addition of an sql parameter to the list of parameters
    ///it accepts two parameters the name of the parameter and its value
    {
        //create a new instance of the sql parameter object
        SqlParameter AParam = new SqlParameter(ParamName, ParamValue);
        //add the parameter to the list
        SQLParams.Add(AParam);
    }

    public Int32 Execute(string SProcName)
    {
        ///public method used to execute the named stored procedure
        ///accepts one parameter which is the name of the stored procedure to use
        //open the stored procedure
        //initialise the connection to the database
        connectionToDB = new SqlConnection(connectionString);
        //open the database
        connectionToDB.Open();
        //initialise the command builder for this connection
        SqlCommand dataCommand = new SqlCommand(SProcName, connectionToDB);
        //add the parameters to the command builder
        //loop through each parameter
        for (int Counter = 0; Counter < SQLParams.Count; Counter += 1)
        {
            //add it to the command builder
            dataCommand.Parameters.Add(SQLParams[Counter]);
        }
        //create an instance of the SqlParameter class
        SqlParameter returnValue = new SqlParameter();
        //set the direction as the return value
        returnValue.Direction = ParameterDirection.ReturnValue;
        //add this parameter to the Command builder
        dataCommand.Parameters.Add(returnValue);
        //set the command type as stored procedure
        dataCommand.CommandType = CommandType.StoredProcedure;
        //initialise the data adapter
        dataChannel = new SqlDataAdapter(SProcName, connectionToDB);
        //set the select command property for the data adapter
        dataChannel.SelectCommand = dataCommand;
        //use the copmmand builder to generate the sql insert delete etc
        commandBuilder = new SqlCommandBuilder(dataChannel);
        //fill the data adapter
        dataChannel.Fill(dataTable);
        //close the connection
        connectionToDB.Close();
        //return the result of the stored procedure
        return Convert.ToInt32(returnValue.Value);
    }

    public Int32 Count
    //property that returns the count of records in the query results
    {
        get
        {
            //return the count of the query results
            return dataTable.Rows.Count;
        }
    }

    public DataTable DataTable
    //public property that provides access to the query results
    {
        get
        {
            //return the query results
            return dataTable;
        }
        set
        {
            //set the query results
            dataTable = value;
        }
    }
}
