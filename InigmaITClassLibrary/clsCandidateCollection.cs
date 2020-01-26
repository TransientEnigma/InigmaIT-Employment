using System.Collections.Generic;

namespace InigmaITClassLibrary
{
    public class clsCandidateCollection
    {


        //private data member for the CandidateList
        private List<clsCandidate> pmCandidateList = new List<clsCandidate>();


        //public property for the count
        public int CandidateCount
        {
            get
            {
                //return the count property of the private list
                return pmCandidateList.Count;
            }
            set
            {

            }
        }


        //public property for the CandidateList
        public List<clsCandidate> CandidateList
        {
            get
            {
                //return the private member variable for CandidateList 
                return pmCandidateList;
            }
            set
            {
                //assign the incomming value to the private member variable
                pmCandidateList = value;
            }
        }

        //public constructor for the class for TTD, code for adding 2 records
        public clsCandidateCollection()
        {
            //create a test candidate to go in the list (set to defaults)
            clsCandidate testCandidate = new clsCandidate();
            //add test candidate data
            testCandidate.CandidateNo = "2430705";
            testCandidate.CandidateTitle = "Mr";
            testCandidate.CandidateFirstName = "Janzeb";
            testCandidate.CandidateLastName = "Masiano";
            testCandidate.CandidateBirthDate = "1988/01/14";
            testCandidate.CandidateAddress = "212 De Montfort University, The Gateway, Leicester";
            testCandidate.CandidatePostCode = "LE1 9BH";
            testCandidate.CandidatePhone = "07816152348";
            testCandidate.CandidateEmail = "P2430705@my365.dmu.ac.uk";
            testCandidate.CandidateUsername = "JMasiano1234";
            testCandidate.CandidatePassword = "An7th1n9G05";
            testCandidate.CandidateSecurityAnswer = "Is a secrete 1";
            testCandidate.CandidateDateRegistered = "2020/01/14";
            //add the test candidate to the test list
            pmCandidateList.Add(testCandidate);

            //reset with defaults
            testCandidate = new clsCandidate();
            //add test candidate data
            testCandidate.CandidateNo = "3450806";
            testCandidate.CandidateTitle = "Mrs";
            testCandidate.CandidateFirstName = "Diana";
            testCandidate.CandidateLastName = "Troy";
            testCandidate.CandidateBirthDate = "1995/07/11";
            testCandidate.CandidateAddress = "32 Themyscira Street, London";
            testCandidate.CandidatePostCode = "W1 1AA";
            testCandidate.CandidatePhone = "07816152348";
            testCandidate.CandidateEmail = "P2430705@my365.dmu.ac.uk";
            testCandidate.CandidateUsername = "DTroy35426";
            testCandidate.CandidatePassword = "An7th1n9G05";
            testCandidate.CandidateSecurityAnswer = "Fictional";
            testCandidate.CandidateDateRegistered = "2020/01/14";
            //add the test candidate to the test list
            pmCandidateList.Add(testCandidate);

        }

    }
}