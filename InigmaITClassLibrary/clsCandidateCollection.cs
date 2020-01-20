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

    }
}