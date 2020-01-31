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
            //test number of records and count are equal they are equal
            Assert.AreEqual(aCandidateCollection.CandidateCount, aCandidateCollection.NumberOfRecords);


        }

        [TestMethod]
        public void CandidateListOK() //NOTE: This fails when the connection string is not hard coded in clsDataConnection
        {
            //create an instance of the collection class
            clsCandidateCollection aCandidateCollection = new clsCandidateCollection();

            //create some test list
            List<clsCandidate> testCandidateList = new List<clsCandidate>();

            //create a test candidate to go in the list
            clsCandidate testCandidate = new clsCandidate();

            //add test candidate data
            testCandidate.CandidateNo = 2430705;
            testCandidate.CandidateTitle = "Mr";
            testCandidate.CandidateFirstName = "Janzeb";
            testCandidate.CandidateLastName = "Masiano";
            testCandidate.CandidateBirthDate = Convert.ToDateTime("1988/01/14");
            testCandidate.CandidateAddress = "212 De Montfort University, The Gateway, Leicester";
            testCandidate.CandidatePostCode = "LE1 9BH";
            testCandidate.CandidatePhone = "07816152348";
            testCandidate.CandidateEmail = "P2430705@my365.dmu.ac.uk";
            testCandidate.CandidateUsername = "JMasiano1234";
            testCandidate.CandidatePassword = "An7th1n9G05";
            testCandidate.CandidateSecurityAnswer = "Is a secrete 1";
            testCandidate.CandidateDateRegistered = Convert.ToDateTime("2020/01/14");

            //add the test candidate to the test list
            testCandidateList.Add(testCandidate);

            //assign the data the the property
            aCandidateCollection.CandidateList = testCandidateList;

            //check they are  equal
            Assert.AreEqual(aCandidateCollection.CandidateList, testCandidateList);


        }

        [TestMethod]
        public void CountMatchesCandidateListOK()
        {
            //create an instance of the collection class
            clsCandidateCollection aCandidateCollection = new clsCandidateCollection();

            //create some test list
            List<clsCandidate> testCandidateList = new List<clsCandidate>();

            //create a test candidate to go in the list
            clsCandidate testCandidate = new clsCandidate();

            //add test candidate data
            testCandidate.CandidateNo = 2430705;
            testCandidate.CandidateTitle = "Mr";
            testCandidate.CandidateFirstName = "Janzeb";
            testCandidate.CandidateLastName = "Masiano";
            testCandidate.CandidateBirthDate = Convert.ToDateTime("1988/01/14");
            testCandidate.CandidateAddress = "212 De Montfort University, The Gateway, Leicester";
            testCandidate.CandidatePostCode = "LE1 9BH";
            testCandidate.CandidatePhone = "07816152348";
            testCandidate.CandidateEmail = "P2430705@my365.dmu.ac.uk";
            testCandidate.CandidateUsername = "JMasiano1234";
            testCandidate.CandidatePassword = "An7th1n9G05";
            testCandidate.CandidateSecurityAnswer = "Is a secrete 1";
            testCandidate.CandidateDateRegistered = Convert.ToDateTime("2020/01/14");

            //add the test candidate to the test list
            testCandidateList.Add(testCandidate);

            //assign the data the the property
            aCandidateCollection.CandidateList = testCandidateList;

            //test to see that the  CandidateCount (property of Collection class) and testList.Count (built in method that returns count) are same
            Assert.AreEqual(aCandidateCollection.CandidateCount, testCandidateList.Count);
        }

        //making of the someCandidate property  in clsCandidateCollection
        [TestMethod]
        public void someCandidatePropertyOK()
        {
            //create an instance of the collection class
            clsCandidateCollection aCandidateCollection = new clsCandidateCollection();


            //create a test candidate to go in the list
            clsCandidate testCandidate = new clsCandidate();

            //add test candidate data
            testCandidate.CandidateNo = 2430705;
            testCandidate.CandidateTitle = "Mr";
            testCandidate.CandidateFirstName = "Janzeb";
            testCandidate.CandidateLastName = "Masiano";
            testCandidate.CandidateBirthDate = Convert.ToDateTime("1988/01/14");
            testCandidate.CandidateAddress = "212 De Montfort University, The Gateway, Leicester";
            testCandidate.CandidatePostCode = "LE1 9BH";
            testCandidate.CandidatePhone = "07816152348";
            testCandidate.CandidateEmail = "P2430705@my365.dmu.ac.uk";
            testCandidate.CandidateUsername = "JMasiano1234";
            testCandidate.CandidatePassword = "An7th1n9G05";
            testCandidate.CandidateSecurityAnswer = "Is a secrete 1";
            testCandidate.CandidateDateRegistered = Convert.ToDateTime("2020/01/14");


            //assign the data the the property
            aCandidateCollection.someCandidate = testCandidate;

            //test to see that the  the property in aCandidateCollection is the same as testCandidate
            Assert.AreEqual(aCandidateCollection.someCandidate, testCandidate);
        }

    }
}
