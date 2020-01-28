using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace InigmaITClassLibrary
{

    public class clsCandidateCollection
    {

        //declare a dataconnection object by name
        clsDataConnection databaseConnection;

        //private member variable for someCandidate
        private clsCandidate pmSomeCandidate;
        //public property used to pass in and retrieve candidate data
        public clsCandidate someCandidate
        {
            get
            {
                //return the private member variable for someCandidate 
                return pmSomeCandidate;
            }
            set
            {
                //assign the incomming value to the private member variable
                pmSomeCandidate = value;
            }

        }
        //var to store the number of records retrieved from database tblCandidate
        Int32 numberOfRecords = 0;
        //private data member for the CandidateList
        private List<clsCandidate> pmCandidateList = new List<clsCandidate>();
        //public property for the CandidateList
        public List<clsCandidate> CandidateList
        {
            get
            {



                //dataconnection object by name is referenced, so connection is same as declared at top of page
                databaseConnection = new clsDataConnection();


                //execute stored procedure to load the datatable with retrieved records
                databaseConnection.Execute("sproc_tblCandidate_SelectAllCandidates");

                //get the number of records in the database 
                numberOfRecords = databaseConnection.Count;
                //create an instance of clsCandiate
                clsCandidate aCandidate = new clsCandidate();
                //use the index to loop through the datatable to get the records
                Int32 dataTableIndex = 0;
                //while the index is less than the number of records keep looping
                while( dataTableIndex < numberOfRecords)
                {
                    //get the candidate number from the dataTable and store in the candidate object CandidateNo property
                    aCandidate.CandidateNo = Convert.ToInt32(databaseConnection.DataTable.Rows[dataTableIndex]["CandidateNo"]);
                    //get the CandidateTitle from the dataTable and store in the candidate object CandidateTitle property
                    aCandidate.CandidateTitle = Convert.ToString(databaseConnection.DataTable.Rows[dataTableIndex]["CandidateTitle"]);
                    //get the CandidateFirstName from the dataTable and store in the candidate object CandidateFirstName property
                    aCandidate.CandidateFirstName = Convert.ToString(databaseConnection.DataTable.Rows[dataTableIndex]["CandidateFirstName"]);
                    //get the CandidateLastName from the dataTable and store in the candidate object CandidateLastName property
                    aCandidate.CandidateLastName = Convert.ToString(databaseConnection.DataTable.Rows[dataTableIndex]["CandidateLastName"]);
                    //get the CandidateBirthDate from the dataTable and store in the candidate object CandidateBirthDate property
                    aCandidate.CandidateBirthDate = Convert.ToDateTime(databaseConnection.DataTable.Rows[dataTableIndex]["CandidateBirthDate"]);
                    //get the CandidateAddress from the dataTable and store in the candidate object CandidateAddress property
                    aCandidate.CandidateAddress = Convert.ToString(databaseConnection.DataTable.Rows[dataTableIndex]["CandidateAddress"]);
                    //get the CandidatePostCode from the dataTable and store in the candidate object CandidatePostCode property
                    aCandidate.CandidatePostCode = Convert.ToString(databaseConnection.DataTable.Rows[dataTableIndex]["CandidatePostCode"]);
                    //get the CandidatePhone from the dataTable and store in the candidate object CandidatePhone property
                    aCandidate.CandidatePhone = Convert.ToString(databaseConnection.DataTable.Rows[dataTableIndex]["CandidatePhone"]);
                    //get the CandidateEmail from the dataTable and store in the candidate object CandidateEmail property
                    aCandidate.CandidateEmail = Convert.ToString(databaseConnection.DataTable.Rows[dataTableIndex]["CandidateEmail"]);
                    //get the CandidateUsername from the dataTable and store in the candidate object CandidateUsername property
                    aCandidate.CandidateUsername = Convert.ToString(databaseConnection.DataTable.Rows[dataTableIndex]["CandidateUsername"]);
                    //get the CandidatePassword from the dataTable and store in the candidate object CandidatePassword property
                    aCandidate.CandidatePassword = Convert.ToString(databaseConnection.DataTable.Rows[dataTableIndex]["CandidatePassword"]);
                    //get the CandidateSecurityAnswer from the dataTable and store in the candidate object CandidateSecurityAnswer property
                    aCandidate.CandidateSecurityAnswer = Convert.ToString(databaseConnection.DataTable.Rows[dataTableIndex]["CandidateSecurityAnswer"]);
                    //get the CandidateDateRegistered from the dataTable and store in the candidate object CandidateDateRegistered property
                    aCandidate.CandidateDateRegistered = Convert.ToDateTime(databaseConnection.DataTable.Rows[dataTableIndex]["CandidateDateRegistered"]);
                    //get the CandidateAccountLock from the dataTable and store in the candidate object CandidateAccountLock property
                    aCandidate.CandidateAccountLock = Convert.ToBoolean(databaseConnection.DataTable.Rows[dataTableIndex]["CandidateAccountLock"]);
                    //once someCandidate data is added, we can add someCandidate to pmCandidateList
                    pmCandidateList.Add(aCandidate);

                    //increment the index, to get the next candidate
                    dataTableIndex++;
                }


                //return the private member variable for CandidateList 
                return pmCandidateList;
            }
            set
            {
                //required for TDD
                //assign the incomming value to the private member variable
                pmCandidateList = value;
            }
        }
        //public property for the count
        public Int32 CandidateCount
        {
            get
            {
                //return the count property of the private list
                return pmCandidateList.Count;
            }
        }
        //public property for the count
        public Int32 NumberOfRecords
        {
            get
            {
                //return the count property of the private list
                return numberOfRecords;
            }

        }

    }
}