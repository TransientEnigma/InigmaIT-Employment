using System;
using InigmaITClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestInigmaIT
{
    [TestClass]
    public class tstCandidateCollection
    {
        [TestMethod]
        public void InstanceOfclsCandidateCollection()
        {
            //create an instance of the class
            clsCandidateCollection aCandidateCollection = new clsCandidateCollection();

            //test it exists
            Assert.IsNotNull(aCandidateCollection);
        }

        [TestMethod]
        public void CandidateCountOK()
        {
            //create an instance of the class
            clsCandidateCollection aCandidateCollection = new clsCandidateCollection();

            //create some test data
            Int32 aCount = 12;

            //assign the data
            aCandidateCollection.Count = aCount;

            //test they are equal
            Assert.AreEqual(aCandidateCollection.Count, aCount);


        }

        [TestMethod]
        public void ListOfCandidatesOK()
        {
            //create an instance of the class
            clsCandidateCollection aCandidateCollection = new clsCandidateCollection();

            //create some test data, in this case the data is a list of objects
            List<clsCandidate> list = new List<clsCandidate>();

            //create some test data to go in the list

            ////create test data for following validation tests
            //string candidateNo = "2430705";
            //string candidateTitle = "Mr";
            //string candidateFirstName = "Janzeb";
            //string candidateLastName = "Masiano";
            //string candidateBirthDate = "1988/01/14";
            //string candidateAddress = "212 De Montfort University, The Gateway, Leicester";
            //string candidatePostCode = "LE1 9BH";
            //string candidatePhone = "07816152348";
            //string candidateEmail = "P2430705@my365.dmu.ac.uk";
            //string candidateUsername = "JMasiano1234";
            //string candidatePassword = "An7th1n9G05";
            //string candidateSecurityAnswer = "Is a secrete 69";
            //string candidateDateRegistered = "2020/01/14";
        }

    }
}
