using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace InigmaITClassLibrary
{

    public class clsCandidateCollection
    {

        //declare a dataconnection object by name (to use as reference object)
        clsDataConnection inigmaITConnection;

        //create an instance of clsCandidate (pmSomeCandidate) and initialise the object.
        //private member variable (object) for SomeCandidate
        private clsCandidate pmSomeCandidate = new clsCandidate();
        //public property used to pass in and retrieve candidate data
        public clsCandidate SomeCandidate
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


        //private member variable for NumberOfRecords
        private Int32 pmNumberOfRecords;
        //public property for the count
        public Int32 NumberOfRecords
        {
            get
            {
                //return the count property of the private list
                return pmNumberOfRecords;
            }
            set
            {
                //assign the incomming value to the private member variable
                pmNumberOfRecords = value;
            }

        }
        //private member variable for CandidateCount
        private Int32 pmCandidateCount;
        //public property for the count
        public Int32 CandidateCount
        {
            get
            {
                //return the count property of the private list
                return pmCandidateList.Count;
            }
            set
            {
                //assign the incomming value to the private member variable
                pmCandidateCount = value;
            }
        }

        /******************************* Add a Candidate *******************************************/
        public Boolean AddCandidate()
        {
            //try to add the candidate
            try
            {
                //reset the connection object (referenced as inigmaITConnection)
                inigmaITConnection = new clsDataConnection();

                //using some candidate to pass CandidateTitle value for @CandidateTitle parameter
                inigmaITConnection.AddParameter("@CandidateTitle", SomeCandidate.CandidateTitle);
                //using some candidate to pass CandidateFirstName value for @CandidateFirstName parameter
                inigmaITConnection.AddParameter("@CandidateFirstName", SomeCandidate.CandidateFirstName);
                //using some candidate to pass CandidateLastName value for @CandidateLastName parameter
                inigmaITConnection.AddParameter("@CandidateLastName", SomeCandidate.CandidateLastName);
                //using some candidate to pass CandidateBirthDate value for @CandidateBirthDate parameter
                inigmaITConnection.AddParameter("@CandidateBirthDate", SomeCandidate.CandidateBirthDate);
                //using some candidate to pass CandidateAddress value for @CandidateAddress parameter
                inigmaITConnection.AddParameter("@CandidateAddress", SomeCandidate.CandidateAddress);
                //using some candidate to pass CandidatePostCode value for @CandidatePostCode parameter
                inigmaITConnection.AddParameter("@CandidatePostCode", SomeCandidate.CandidatePostCode);
                //using some candidate to pass CandidatePhone value for @CandidatePhone parameter
                inigmaITConnection.AddParameter("@CandidatePhone", SomeCandidate.CandidatePhone);
                //using some candidate to pass CandidateEmail value for @CandidateEmail parameter
                inigmaITConnection.AddParameter("@CandidateEmail", SomeCandidate.CandidateEmail);
                //using some candidate to pass CandidateUsername value for @CandidateUsername parameter
                inigmaITConnection.AddParameter("@CandidateUsername", SomeCandidate.CandidateUsername);
                //using some candidate to pass CandidatePassword value for @CandidatePassword parameter
                inigmaITConnection.AddParameter("@CandidatePassword", SomeCandidate.CandidatePassword);
                //using some candidate to pass CandidateSecurityAnswer value for @CandidateSecurityAnswer parameter
                inigmaITConnection.AddParameter("@CandidateSecurityAnswer", SomeCandidate.CandidateSecurityAnswer);
                //using some candidate to pass CandidateCVFile value for @CandidateCVFile parameter
                inigmaITConnection.AddParameter("@CandidateCVFile", SomeCandidate.CandidateCVFile);

                //Execute the stored procedure to add the candidate details to the  tblCandidate in the database
                inigmaITConnection.Execute("sproc_tblCandidate_AddCandidate");

                //return true to report program stub completion
                return true;
            }
            //if the candidate can not be added
            catch
            {
                //return false to report a problem
                return false;
            }
        }



        /****************************** List Array Property ***************************************/
        //private data member for the CandidateList
        private List<clsCandidate> pmCandidateList = new List<clsCandidate>();
        //public property for the CandidateList
        public List<clsCandidate> CandidateList
        {
            get
            {



                //dataconnection  name is object referenced, so connection is same as declared at top of page
                inigmaITConnection =  new clsDataConnection();

                //execute stored procedure to load the datatable with retrieved records
                inigmaITConnection.Execute("sproc_tblCandidate_SelectAllCandidates");

                //get the number of records in the database 
                NumberOfRecords = inigmaITConnection.Count;
                //create an instance of clsCandiate
                clsCandidate aCandidate = new clsCandidate();
                //use the index to loop through the datatable to get the records
                Int32 dataTableIndex = 0;
                //while the index is less than the number of records keep looping
                while( dataTableIndex < NumberOfRecords)
                {
                    //get the candidate number from the dataTable and store in the candidate object CandidateNo property
                    aCandidate.CandidateNo = Convert.ToInt32(inigmaITConnection.DataTable.Rows[dataTableIndex]["CandidateNo"]);
                    //get the CandidateTitle from the dataTable and store in the candidate object CandidateTitle property
                    aCandidate.CandidateTitle = Convert.ToString(inigmaITConnection.DataTable.Rows[dataTableIndex]["CandidateTitle"]);
                    //get the CandidateFirstName from the dataTable and store in the candidate object CandidateFirstName property
                    aCandidate.CandidateFirstName = Convert.ToString(inigmaITConnection.DataTable.Rows[dataTableIndex]["CandidateFirstName"]);
                    //get the CandidateLastName from the dataTable and store in the candidate object CandidateLastName property
                    aCandidate.CandidateLastName = Convert.ToString(inigmaITConnection.DataTable.Rows[dataTableIndex]["CandidateLastName"]);
                    //get the CandidateBirthDate from the dataTable and store in the candidate object CandidateBirthDate property
                    aCandidate.CandidateBirthDate = Convert.ToDateTime(inigmaITConnection.DataTable.Rows[dataTableIndex]["CandidateBirthDate"]);
                    //get the CandidateAddress from the dataTable and store in the candidate object CandidateAddress property
                    aCandidate.CandidateAddress = Convert.ToString(inigmaITConnection.DataTable.Rows[dataTableIndex]["CandidateAddress"]);
                    //get the CandidatePostCode from the dataTable and store in the candidate object CandidatePostCode property
                    aCandidate.CandidatePostCode = Convert.ToString(inigmaITConnection.DataTable.Rows[dataTableIndex]["CandidatePostCode"]);
                    //get the CandidatePhone from the dataTable and store in the candidate object CandidatePhone property
                    aCandidate.CandidatePhone = Convert.ToString(inigmaITConnection.DataTable.Rows[dataTableIndex]["CandidatePhone"]);
                    //get the CandidateEmail from the dataTable and store in the candidate object CandidateEmail property
                    aCandidate.CandidateEmail = Convert.ToString(inigmaITConnection.DataTable.Rows[dataTableIndex]["CandidateEmail"]);
                    //get the CandidateUsername from the dataTable and store in the candidate object CandidateUsername property
                    aCandidate.CandidateUsername = Convert.ToString(inigmaITConnection.DataTable.Rows[dataTableIndex]["CandidateUsername"]);
                    //get the CandidatePassword from the dataTable and store in the candidate object CandidatePassword property
                    aCandidate.CandidatePassword = Convert.ToString(inigmaITConnection.DataTable.Rows[dataTableIndex]["CandidatePassword"]);
                    //get the CandidateSecurityAnswer from the dataTable and store in the candidate object CandidateSecurityAnswer property
                    aCandidate.CandidateSecurityAnswer = Convert.ToString(inigmaITConnection.DataTable.Rows[dataTableIndex]["CandidateSecurityAnswer"]);
                    //get the CandidateSecurityAnswer from the dataTable and store in the candidate object CandidateCVFile property
                    aCandidate.CandidateCVFile = Convert.ToString(inigmaITConnection.DataTable.Rows[dataTableIndex]["CandidateCVFile"]);
                    //get the CandidateDateRegistered from the dataTable and store in the candidate object CandidateDateRegistered property
                    aCandidate.CandidateDateRegistered = Convert.ToDateTime(inigmaITConnection.DataTable.Rows[dataTableIndex]["CandidateDateRegistered"]);
                    //get the CandidateAccountLock from the dataTable and store in the candidate object CandidateAccountLock property
                    aCandidate.CandidateAccountLock = Convert.ToBoolean(inigmaITConnection.DataTable.Rows[dataTableIndex]["CandidateAccountLock"]);
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


    }
}