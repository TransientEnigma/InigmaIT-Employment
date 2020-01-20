using System;
using InigmaITClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestInigmaIT
{
    [TestClass]
    public class tstCandidate
    {
        /**************************** Instance of clsCandidate *********************/
        [TestMethod]
        public void InstanceOfclsCandidateOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();
            //check it exists
            Assert.IsNotNull(aCandidate);
        }
        /************************** Properties of class *************************/
        [TestMethod]
        public void CandidateNoOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();
            //create test data
            string Number = "2430705";
            //assign test data to property
            aCandidate.CandidateNo= Number;
            //check they are equal
            Assert.AreEqual(aCandidate.CandidateNo, Number);
        }
        [TestMethod]
        public void CandidateTitleOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();
            //create test data
            string title = "Mr";
            //assign test data to property
            aCandidate.CandidateTitle = title;
            //check they are equal
            Assert.AreEqual(aCandidate.CandidateTitle, title);
        }
        [TestMethod]
        public void CandidateFirstNameOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();
            //create test data
            string firstName = "Janzeb";
            //assign test data to property
            aCandidate.CandidateFirstName = firstName;
            //check they are equal
            Assert.AreEqual(aCandidate.CandidateFirstName, firstName);
        }
        [TestMethod]
        public void CandidateLastNameOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();
            //create test data
            string lastName = "Masiano";
            //assign test data to property
            aCandidate.CandidateLastName = lastName;
            //check they are equal
            Assert.AreEqual(aCandidate.CandidateLastName, lastName);
        }
        [TestMethod]
        public void CandidateBirthDateOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();
            //create test data
            string birthday = "2020/01/14";
            //assign test data to property
            aCandidate.CandidateBirthDate = birthday;
            //check they are equal
            Assert.AreEqual(aCandidate.CandidateBirthDate, birthday);
        }
        [TestMethod]
        public void CandidateAddressOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();
            //create test data
            string address = "De Montfort University, The Gateway, Leicester, LE1 9BH";
            //assign test data to property
            aCandidate.CandidateAddress = address;
            //check they are equal
            Assert.AreEqual(aCandidate.CandidateAddress, address);
        }
        [TestMethod]
        public void CandidatePostCodeOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();
            //create test data
            string postCode = "LE1 9BH";
            //assign test data to property
            aCandidate.CandidatePostCode = postCode;
            //check they are equal
            Assert.AreEqual(aCandidate.CandidatePostCode, postCode);
        }
        [TestMethod]
        public void CandidatePhoneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();
            //create test data
            string phone = "07816152348";
            //assign test data to property
            aCandidate.CandidatePhone = phone;
            //check they are equal
            Assert.AreEqual(aCandidate.CandidatePhone, phone);
        }

        [TestMethod]
        public void CandidateEmailOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();
            //create test data
            string email = "P2430705@my365.dmu.ac.uk";
            //assign test data to property
            aCandidate.CandidateEmail = email;
            //check they are equal
            Assert.AreEqual(aCandidate.CandidateEmail, email);
        }
        [TestMethod]
        public void CandidateUsernameOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();
            //create test data
            string username = "JMasiano1234";
            //assign test data to property
            aCandidate.CandidateUsername = username;
            //check they are equal
            Assert.AreEqual(aCandidate.CandidateUsername, username);
        }
        [TestMethod]
        public void CandidatePasswordOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();
            //create test data
            string password = "An7th1n9";
            //assign test data to property
            aCandidate.CandidatePassword = password;
            //check they are equal
            Assert.AreEqual(aCandidate.CandidatePassword, password);
        }
        [TestMethod]
        public void CandidateSecurityAnswerOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();
            //create test data
            string answer = "yellow-blue";
            //assign test data to property
            aCandidate.CandidateSecurityAnswer = answer;
            //check they are equal
            Assert.AreEqual(aCandidate.CandidateSecurityAnswer, answer);
        }
        [TestMethod]
        public void CandidateDateRegisteredOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();
            //create test data
            string date = "2020/01/14";
            //assign test data to property
            aCandidate.CandidateDateRegistered = date;
            //check they are equal
            Assert.AreEqual(aCandidate.CandidateDateRegistered, date);
        }
        /*************************** Validation Method ***********************/
        //create test data for following validation tests
        string candidateNo = "2430705";
        string candidateTitle = "Mr";
        string candidateFirstName = "Janzeb";
        string candidateLastName = "Masiano";
        string candidateBirthDate = "1988/01/14";
        string candidateAddress = "212 De Montfort University, The Gateway, Leicester";
        string candidatePostCode = "LE1 9BH";
        string candidatePhone = "07816152348";
        string candidateEmail = "P2430705@my365.dmu.ac.uk";
        string candidateUsername = "JMasiano1234";
        string candidatePassword = "An7th1n9G05";
        string candidateSecurityAnswer = "Is a secrete 69";
        string candidateDateRegistered = "2020/01/14";
        //string for errors
        string error = "";

        [TestMethod]
        public void CandidateValidationOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        /******************************* Tests for CandidateNo ************************************/
        [TestMethod]
        public void CandidateNoIsNumOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateNo not non-numbers
            candidateNo = "%><?@()$£!";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void CandidateNoMinLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateNo min - 1
            candidateNo = "0";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void CandidateNoMinOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateNo min is 1
            candidateNo = "1";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateNoMinPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateNo min + 1
            candidateNo = "2";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateNoMaxLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateNo max - 1 
            candidateNo = "99999998";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateNoMaxOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateNo max 99999999
            candidateNo = "99999999";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateNoMaxPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateNo max + 1
            candidateNo = "100000000";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }
        /******************************* Tests for CandidateTitle ********************************/
        [TestMethod]
        public void CandidateTitleCharactersOnlyOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateTitle not non-characters
            candidateTitle = "%><?@()$£!";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void CandidateTitleMinLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //CandidateTitle min - 1
            candidateTitle = "M";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void CandidateTitleMinOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateTitle min is 2 characters
            candidateTitle = "Mr";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateTitleMinPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateTitle min + 1
            candidateTitle = "Mrs";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateTitleMaxLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateTitle max - 1 
            candidateTitle = "Professo";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateTitleMaxOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateTitle max (9 characters)
            candidateTitle = "Professor";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateTitleMaxPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateTitle max + 1
            candidateTitle = "Professors";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }

        /******************************* Tests for CandidateFirstName ******************************/
        [TestMethod]
        public void CandidateFirstNameNotNoneCharactersOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateFirstName not non-characters
            candidateFirstName = "%><?@()$£!";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }

        public void CandidateFirstNameCharactersSpacesOnlyOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateFirstName characters and spaces
            candidateFirstName = "Ali Al";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void CandidateFirstNameMinLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateFirstName min - 1 (2 characters)
            candidateFirstName = "Ja";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void CandidateFirstNameMinOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateFirstName min (3 characters)
            candidateFirstName = "Jan";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateFirstNameMinPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateTitle min + 1 (4 characters)
            candidateFirstName = "Janz";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateFirstNameMaxLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateFirstName max - 1 (29 characters)
            candidateFirstName = candidateFirstName.PadRight(29,'a');

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateFirstNameMaxOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateFirstName max (30 characters)
            candidateFirstName = candidateFirstName.PadRight(30,'a');

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateFirstNameMaxPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateFirstName max + 1 (31 characters)
            candidateFirstName = candidateFirstName.PadRight(31, 'a');

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }


        /******************************* Tests for CandidateLastName ******************************/

        [TestMethod]
        public void CandidateLastNameUnacceptableCharactersOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateLastName not non-characters
            candidateLastName = "%><?@()$£!";


            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }

        public void CandidateLastNameCharactersSpacesOnlyOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateLastName characters and spaces
            candidateLastName = "Ali Al";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void CandidateLastNameMinLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateLastName min - 1 (2 characters)
            candidateLastName = "Ja";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void CandidateLastNameMinOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateLastName min (3 characters)
            candidateLastName = "Jan";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateLastNameMinPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateLastName min + 1 (4 characters)
            candidateLastName = "Janz";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateLastNameMaxLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateLastName max - 1 (29 characters)
            candidateLastName = candidateLastName.PadRight(29, 'a');

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateLastNameMaxOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateLastName max (30 characters)
            candidateLastName = candidateLastName.PadRight(30, 'a');

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateLastNameMaxPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateLastName max + 1 (31 characters)
            candidateLastName = candidateLastName.PadRight(31, 'a');

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }

        /******************************* Tests for CandidateBirthDate ******************************/

        [TestMethod]
        public void CandidateBirthDateIsDateOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateBirthDate fails if unacceptable format
            candidateBirthDate = "MMXX/I/I";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void CandidateBirthDateMinLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateBirthDate min - 1day is 31/12/1899
            candidateBirthDate = "1899/12/31";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void CandidateBirthDateMinOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateBirthDate min - 01/01/1900
            candidateBirthDate = "1900/01/01";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateBirthDateMinPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateBirthDate min +1day 02/01/1900
            candidateBirthDate = "1900/01/02";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void CandidateBirthDateMaxLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateBirthDate max (15 years ago) - 1day
            DateTime fifthTeen = DateTime.Today.AddYears(-15);
            fifthTeen = fifthTeen.AddDays(-1);

            //assign to variable yesturday in correct format
            candidateBirthDate = fifthTeen.Year + "/" + fifthTeen.Month + "/" + fifthTeen.Day;

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateBirthDateMaxOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateBirthDate max (15 years ago)
            DateTime fifthTeen = DateTime.Today.AddYears(-15);

            //assign to variable today in correct format
            candidateBirthDate = fifthTeen.Year + "/" + fifthTeen.Month + "/" + fifthTeen.Day;

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateBirthDateMaxPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateBirthDate max (15 years ago) + 1day
            DateTime fifthTeen = DateTime.Today.AddYears(-15);
            fifthTeen = fifthTeen.AddDays(+1);

            //assign to variable tomorrow in correct format
            candidateBirthDate = fifthTeen.Year + "/" + fifthTeen.Month + "/" + fifthTeen.Day;

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }


        /******************************* Tests for CandidateAddress ******************************/

        [TestMethod]
        public void CandidateAddressUnacceptableCharactersOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateAddress characters, numbers, spaces, commas and forward slashes only
            candidateAddress = "%><?@()$£!";
           
            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }

        public void CandidateAddressAcceptableCharactersOnlyOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateAddress characters, numbers, spaces, commas and forward slashes only
            candidateAddress = "Flat 1/2, Gateway House, Leicester, LE1 9BH";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void CandidateAddressMinLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateAddress min - 1 (6 characters)
            candidateAddress = "123Abc";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void CandidateAddressMinOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateAddress min (7 characters, including space)
            candidateAddress = "123 Abc";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateAddressMinPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateAddress min + 1 (4 characters, including space)
            candidateAddress = "1234 Abc";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateAddressMaxLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateAddress max - 1 (199 characters)
            candidateAddress = candidateLastName.PadRight(199, 'a');

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateAddressMaxOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateAddress max (200 characters)
            candidateAddress = candidateLastName.PadRight(200, 'a');

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateAddressMaxPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateAddress max + 1 (201 characters)
            candidateAddress = candidateLastName.PadRight(201, 'a');

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }
        /******************************* Tests for CandidatePostCode ******************************/

        [TestMethod]
        public void CandidatePostCodeUnacceptableCharactersOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePostCode characters, numbers, spaces, commas and forward slashes only
            candidatePostCode = "%>?@$£!";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void CandidatePostCodeMinLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePostCode min - 1 (5 characters)
            candidatePostCode = "LE19B";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void CandidatePostCodeMinOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePostCode min(6 characters, including space)
            candidatePostCode = "W1 7JH";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidatePostCodeMinPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePostCode min + 1 (7 characters, including space)
            candidatePostCode = "LE2 7JH";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidatePostCodeMaxLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePostCode max - 1 (8 characters, including space)
            candidatePostCode = "LE22 7JH";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidatePostCodeMaxOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePostCode max (9 characters, including space)
            candidatePostCode = "LE22 77JH";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidatePostCodeMaxPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePostCode max + 1 (10 characters, including space)
            candidatePostCode = "LE22 77JHY";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }



        /******************************* Tests for CandidatePhone ******************************/


        [TestMethod]
        public void CandidatePhoneNonNumbersOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePhone non-numbers not accepted
            candidatePhone = "abc,'[p~#;kjf";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }

 
        [TestMethod]
        public void CandidatePhoneMinLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePhone min - 1 (9 digits)
            candidatePhone = "123456789";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void CandidatePhoneMinOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePhone min (10 digits)
            candidatePhone = "0123456789";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidatePhoneMinPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePhone min + 1 (11 digits)
            candidatePhone = "01234567891";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidatePhoneMaxLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePhone max - 1 (13 digits)
            candidatePhone = "1234567890123";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidatePhoneMaxOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePhone max (14 digits)
            candidatePhone = "12345678901234";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidatePhoneMaxPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePhone max + 1 (15 digits)
            candidatePhone = "123456789012345";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");
        }



        /******************************* Tests for CandidateEmail ******************************/

        [TestMethod]
        public void CandidateEmailUnacceptableCharactersOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateEmail characters, numbers, spaces, commas and forward slashes only
            candidateEmail = "%><?@()$.£!";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void CandidateEmailAcceptableCharactersOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateEmail characters, numbers, spaces, commas and forward slashes only
            candidateEmail = "P2430705@my365.dmu.ac.uk";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateEmailNoAtSymbolOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateEmail characters, numbers, spaces, commas and forward slashes only
            candidateEmail = "P2430705my365.dmu.ac.uk";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void CandidateEmailMinLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateEmail min - 1 (6 characters)
            candidateEmail = "a@b.cm";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void CandidateEmailMinOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateEmail min (7 characters)
            candidateEmail = "a@b.com";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateEmailMinPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateEmail min + 1 (8 characters)
            candidateEmail = "a@bc.com";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateEmailMaxLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateEmail max + 1 (99 = 91 characters + 8 characters)
            candidateEmail = candidateLastName.PadRight(91, 'a');
            candidateEmail += "@abc.com";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateEmailMaxOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateEmail max (100 = 92 characters + 8 characters)
            candidateEmail = candidateLastName.PadRight(92, 'a');
            candidateEmail += "@abc.com";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateEmailMaxPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateEmail max + 1 (101 = 93 characters + 8 characters)
            candidateEmail = candidateLastName.PadRight(193, 'a');
            candidateEmail += "@abc.com";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }



        /******************************* Tests for CandidateUsername ******************************/
        [TestMethod]
        public void CandidateUsernameUnacceptableCharactersOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateUsername characters, numbers, spaces, commas and forward slashes only
            candidateUsername = "%><?@()$.£!";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }
        public void CandidateUsernameCharactersNoSpacesOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateUsername no spaces allowed
            candidateUsername = "Ali Al";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void CandidateUsernameMinLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateUsername min - 1 (9 characters)
            candidateUsername = "AbcDefGh1";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void CandidateUsernameNameMinOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateUsername min (10 characters)
            candidateUsername = "AbcDefGh12";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateUsernameMinPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateUsername min + 1 (4 characters)
            candidateUsername = "AbcDefGh123";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateUsernameMaxLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateUsername max - 1 (29 characters)
            candidateUsername = candidateUsername.PadRight(29, 'a');

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateUsernameMaxOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateUsername max (30 characters)
            candidateUsername = candidateUsername.PadRight(30, 'a');

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateUsernameMaxPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateUsername max + 1 (31 characters)
            candidateUsername = candidateUsername.PadRight(31, 'a');

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }



        /******************************* Tests for CandidatePassword ******************************/

        public void CandidatePasswordUnacceptableCharactersOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePassword characters, numbers, spaces, commas and forward slashes only
            candidatePassword = "%><?@()$.£!";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");
        }
        public void CandidatePasswordCharactersNoSpacesOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePassword no spaces allowed
            candidatePassword = "Ali Al";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void CandidatePasswordMinLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePassword min - 1 (9 characters)
            candidatePassword = "AbcDefGh1";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void CandidatePasswordNameMinOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePassword min (10 characters)
            candidatePassword = "AbcDefGh12";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidatePasswordMinPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePassword min + 1 (11 characters)
            candidatePassword = "AbcDefGh123";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidatePasswordMaxLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePassword max - 1 (29 characters)
            candidatePassword = candidateUsername.PadRight(29, 'a');

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidatePasswordMaxOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePassword max (30 characters)
            candidatePassword = candidateUsername.PadRight(30, 'a');

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidatePasswordMaxPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidatePassword max + 1 (31 characters)
            candidatePassword = candidateUsername.PadRight(31, 'a');

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }



        /******************************* Tests for CandidateSecurityAnswer ******************************/


        [TestMethod]
        public void CandidateSecurityAnswerUnacceptableCharactersOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateSecurityAnswer characters, numbers, spaces, commas and forward slashes only
            candidateSecurityAnswer = "%><?@()$£!";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }

        public void CandidateSecurityAnswerAcceptableCharactersOnlyOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateSecurityAnswer characters, numbers, spaces only
            candidateSecurityAnswer = "Alita Battle Angel 2";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void CandidateSecurityAnswerMinLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateSecurityAnswer min - 1 (9 characters)
            candidatePassword = "AbcDefGh1";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void CandidateSecurityAnswerMinOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateSecurityAnswer min (10 characters, including space)
            candidatePassword = "AbcDefGh12";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateSecurityAnswerMinPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateSecurityAnswer min + 1 (11 characters, including space)
            candidatePassword = "AbcDefGh123";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateSecurityAnswerMaxLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateAddress max - 1 (199 characters)
            candidateSecurityAnswer = candidateSecurityAnswer.PadRight(29, 'a');

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void CandidateSecurityAnswerMaxOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateAddress max (200 characters)
            candidateSecurityAnswer = candidateSecurityAnswer.PadRight(30, 'a');

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void CandidateSecurityAnswerMaxPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateSecurityAnswer max + 1 (201 characters)
            candidateSecurityAnswer = candidateSecurityAnswer.PadRight(201, 'a');

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");
        }



        /******************************* Tests for CandidateDateRegistered ******************************/

        [TestMethod]
        public void candidateDateRegisteredIsDateOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateBirthDate fails if unacceptable format
            candidateBirthDate = "MMXX/I/I";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void candidateDateRegisteredMinLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateDateRegistered min - 1day is 31/12/2019
            candidateDateRegistered = "2019/12/31";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void candidateDateRegisteredMinOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateDateRegistered min - 1day is 01/01/2020
            candidateDateRegistered = "2020/01/01";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void candidateDateRegisteredMinPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateDateRegistered min +1day 02/01/2020
            candidateDateRegistered = "2020/01/02";

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void candidateDateRegisteredMaxLessOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateBirthDate max Today - 1day
            DateTime yesterday = DateTime.Today.AddDays(-1);

            //assign to variable yesturday in correct format
            candidateDateRegistered = yesterday.Year + "/" + yesterday.Month + "/" + yesterday.Day;

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void candidateDateRegisteredMaxOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateBirthDate max Today
            DateTime today = DateTime.Today;

            //assign to variable today in correct format
            candidateDateRegistered = today.Year + "/" + today.Month + "/" + today.Day;

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are equal
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void candidateDateRegisteredMaxPlusOneOK()
        {
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //candidateDateRegistered max Today + 1day
            DateTime tomorrow = DateTime.Today.AddDays(+1);

            //assign to variable tomorrow in correct format
            candidateDateRegistered = tomorrow.Year + "/" + tomorrow.Month + "/" + tomorrow.Day;

            //assign test data for validation
            error = aCandidate.CandidateValidation(candidateNo,
                                                    candidateTitle,
                                                    candidateFirstName,
                                                    candidateLastName,
                                                    candidateBirthDate,
                                                    candidateAddress,
                                                    candidatePostCode,
                                                    candidatePhone,
                                                    candidateEmail,
                                                    candidateUsername,
                                                    candidatePassword,
                                                    candidateSecurityAnswer,
                                                    candidateDateRegistered);
            //check they are not equal
            Assert.AreNotEqual(error, "");
        }
    }
}
