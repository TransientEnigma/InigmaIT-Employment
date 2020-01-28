using System;

namespace InigmaITClassLibrary
{
    public class clsCandidate
    {
        public clsCandidate()
        {
        }
        //private member variable for CandidateNo
        private Int32 pmCandidateNo;
        //public property funtion to access private member
        public Int32 CandidateNo
        {
            get
            {
                //return the private member variable for CandidateNo
                return pmCandidateNo;
            }
            set
            {
                //assign the incomming value to the private member variable
                pmCandidateNo = value;
            }
        }
        //private member variable for CandidateTitle
        private string pmCandidateTitle;
        //public property funtion
        public string CandidateTitle
        {
            get
            {
                //return the private member variable for CandidateTitle
                return pmCandidateTitle;
            }
            set
            {
                //assign the incomming value to the private member variable
                pmCandidateTitle = value;
            }

        }
        //private member variable for CandidateFirstName
        private string pmFirstName;
        //public property funtion
        public string CandidateFirstName
        {
            get
            {
                //return the private member variable for CandidateFirstName
                return pmFirstName;
            }
            set
            {
                //assign the incomming value to the private member variable
                pmFirstName = value;
            }
        }
        //private member variable for CandidateLastName
        private string pmCandidateLastName;
        //public property funtion
        public string CandidateLastName
        {
            get
            {
                //return the private member variable for CandidateLastName
                return pmCandidateLastName;
            }
            set
            {
                //assign the incomming value to the private member variable
                pmCandidateLastName = value;
            }
        }
        //private member variable for CandidateBirthDate
        private DateTime pmCandidateBirthDate;
        //public property funtion
        public DateTime CandidateBirthDate
        {
            get
            {
                //return the private member variable for CandidateBirthDate
                return pmCandidateBirthDate;
            }
            set
            {
                //assign the incomming value to the private member variable
                pmCandidateBirthDate = value;
            }
        }
        //private member variable for CandidateAddress
        private string pmCandidateAddress;
        //public property funtion
        public string CandidateAddress
        {
            get
            {
                //return the private member variable for CandidateAddress
                return pmCandidateAddress;
            }
            set
            {
                //assign the incomming value to the private member variable
                pmCandidateAddress = value;
            }
        }
        //private member variable for CandidatePostCode
        private string pmCandidatePostCode;
        //public property funtion
        public string CandidatePostCode
        {
            get
            {
                //return the private member variable for CandidatePostCode
                return pmCandidatePostCode;
            }
            set
            {
                //assign the incomming value to the private member variable
                pmCandidatePostCode = value;
            }
        }
        //private member variable for CandidatePhone
        private string pmCandidatePhone;
        //public property funtion
        public string CandidatePhone
        {
            get
            {
                //return the private member variable for CandidatePhone
                return pmCandidatePhone;
            }
            set
            {
                //assign the incomming value to the private member variable
                pmCandidatePhone = value;
            }
        }
        //private member variable for CandidateEmail
        private string pmCandidateEmail;
        //public property funtion
        public string CandidateEmail
        {
            get
            {
                //return the private member variable for CandidateEmail
                return pmCandidateEmail;
            }
            set
            {
                //assign the incomming value to the private member variable
                pmCandidateEmail = value;
            }
        }
        //private member variable for CandidateUsername
        private string pmCandidateUsername;
        //public property funtion
        public string CandidateUsername
        {
            get
            {
                //return the private member variable for CandidateUsername
                return pmCandidateUsername;
            }
            set
            {
                //assign the incomming value to the private member variable
                pmCandidateUsername = value;
            }
        }
        //private member variable for CandidatePassword
        private string pmCandidatePassword;
        //public property funtion
        public string CandidatePassword
        {
            get
            {
                //return the private member variable for CandidatePassword
                return pmCandidatePassword;
            }
            set
            {
                //assign the incomming value to the private member variable
                pmCandidatePassword = value;
            }
        }
        //private member variable for CandidateSecurityAnswer
        private string pmCandidateSecurityAnswer;
        //public property funtion
        public string CandidateSecurityAnswer
        {
            get
            {
                //return the private member variable for CandidateSecurityAnswer
                return pmCandidateSecurityAnswer;
            }
            set
            {
                //assign the incomming value to the private member variable
                pmCandidateSecurityAnswer = value;
            }
        }
        //private member variable for CandidateDateRegistered
        private DateTime pmCandidateDateRegistered;
        //public property funtion
        public DateTime CandidateDateRegistered
        {
            get
            {
                //return the private member variable for CandidateDateRegistered
                return pmCandidateDateRegistered;
            }
            set
            {
                //assign the incomming value to the private member variable
                pmCandidateDateRegistered = value;
            }
        }
        //private member variable for CandidateAccountLock
        private bool pmCandidateAccountLock;
        //public property funtion
        public bool CandidateAccountLock
        {
            get
            {
                //return the private member variable for CandidateAccountLock
                return pmCandidateAccountLock;
            }
            set
            {
                //assign the incomming value to the private member variable
                pmCandidateAccountLock = value;
            }
        }
        /************************* Candidate Details Validation Function *************************/
        public string CandidateValidation(string candidateNo, 
                                            string candidateTitle, 
                                            string candidateFirstName,
                                            string candidateLastName, 
                                            string candidateBirthDate, 
                                            string candidateAddress,
                                            string candidatePostCode,
                                            string candidatePhone, 
                                            string candidateEmail,
                                            string candidateUsername,
                                            string candidatePassword,
                                            string candidateConfirmPassword,
                                            string candidateSecurityAnswer, 
                                            string candidateDateRegistered)
        {

            /**************** CandidateNo ****************/
            //CHECK candidateNo IS A WHOLE NUMBER
            try
            {
                //integer to store the candidateNo
                Int32 wholeNumber = 0;
                //convert the string, test its an integer
                wholeNumber = Convert.ToInt32(candidateNo);

                //candidateNo NOT LESS THAN 1 (MIN)
                if (wholeNumber < 1)
                {
                    return "CandidateNo can not be less than zero";
                }
                //candidateNo GREATER 99999999 (MAX)
                if (wholeNumber > 99999999)
                {
                    return "CandidateNo can not be less than zero";
                }
            }
            catch
            {
                //error if candidateNo is not an integer
                return "CandidateNo is not a whole number";
            }
            /********************************** candidateTitle ****************************/
            //Sir(adult male of any age)
            //Madam(adult female)
            //Mr (any man)
            //Mrs e(married woman who uses her husband's last name)
            //Ms (married or unmarried woman; common in business)
            //Miss (unmarried woman)
            //Dr (some doctors go by Dr + first name)
            //Professor (in a university setting)

          
            foreach (char character in candidateTitle)
            {
                //CHECK CANDIDATETILE IS ONLY CHARACTERS
                if ( !( (character >= 'A') && (character <= 'z') ) )
                {
                    //error if not a character
                    return "Title can only contain characters";
                }
            }
 
            //candidateTitle NOT LESS THAN 2 LENGTH (OR BLANK)
            if (candidateTitle.Length < 2) { return "Title can not have less than 2 characters"; }

            //candidateTitle NOT MORE THAN 9 LENGTH
            if (candidateTitle.Length > 9) { return "Title can not have more than 9 characters"; }

            /********************************* candidateFirstName ****************************/
            //traverse the characters in the name
            foreach (char character in candidateFirstName)
            {
                //CHECK candidateFirstName IS ONLY CHARACTERS OR SPACE
                if (!(((character >= 'A') && (character <= 'z')) || (character == ' ')))
                {
                    //error if not a character
                    return "First Name can only contain characters or spaces";
                }
            }

            //candidateFirstName NOT LESS THAN 3 LENGTH (OR BLANK)
            if (candidateFirstName.Length < 3) { return "First Name can not have less than 3 characters"; }

            //candidateFirstName NOT MORE THAN 30 LENGTH
            if (candidateFirstName.Length > 30) { return "First Name can not have more than 30 characters"; }

            /********************************* candidateLastName ****************************/
            //traverse the characters in the name
            foreach (char character in candidateLastName)
            {
                //CHECK candidateLastName IS ONLY CHARACTERS OR SPACE
                if (!(((character >= 'A') && (character <= 'z')) || (character == ' ')))
                {
                    //error if not a character
                    return "Last Name can only contain characters or spaces";
                }
             }

            //candidateLastName NOT LESS THAN 3 LENGTH (OR BLANK)
            if (candidateLastName.Length < 3) { return "Last Name can not have less than 3 characters"; }

            //candidateLastName NOT MORE THAN 30 LENGTH
            if (candidateLastName.Length > 30) { return "Last Name can not have more than 30 characters"; }

            ///******************************* Tests for CandidateBirthDate ******************************/

            //CHECK CandidateBirthDate IS A DATE (AND CORRECT FORMAT)
            try
            {
                //Convert the string to DateTime and store it in DateTime variable to test its a date
                DateTime birthday = Convert.ToDateTime(candidateBirthDate);

                //candidateBirthDate NOT LESS THAN 1/1/1900 (MIN)
                if (birthday < Convert.ToDateTime("1900/01/01"))
                {
                    return "Candidate Birth Date can not be less than 01/01/1900";
                }
                //candidateBirthDate NOT IN FUTURE & MAX 15 YEARS AGO
                if (birthday > DateTime.Today.AddYears(-15))
                {
                    return "You are too young to register";
                }
            }
            catch
            {
                //error if candidateNo is not an integer
                return "candidateBirthDate is not a date";
            }


            ///******************************* Tests for CandidateAddress ******************************/

            //traverse the characters in the CandidateAddress
            foreach (char character in candidateAddress)
            {
                //CHECK EACH CandidateAddress CHARACTER IS ONLY CHARACTER, NUMBER, OR COMMA OR FORWARD SLASH OR SPACE
                if (!(((character >= 'A') && (character <= 'z')) || ((character >= '0') && (character <= '9')) || (character == ',') || (character == '/') || (character == ' ')))
                {
                    //error if contains anything else
                    return "Candidate Address can only contain characters, numbers, spaces, commas (,) or forward slash (/)";
                }
            }

            //CandidateAddress NOT LESS THAN 7 LENGTH (OR BLANK)
            if (candidateAddress.Length < 7) { return "Candidate Address can not have less than 7 characters"; }

            //CandidateAddress NOT MORE THAN 200 LENGTH
            if (candidateAddress.Length > 200) { return "Candidate Address can not have more than 200 characters"; }

            /******************************* Tests for CandidatePostCode ******************************/

            //traverse the characters in the CandidatePostCode
            foreach (char character in candidatePostCode)
            {
                //CHECK CandidateSecurityAnswer IS ONLY CHARACTERS OR NUMBERS OR SPACE
                if (!(((character >= 'A') && (character <= 'z')) || ((character >= '0') && (character <= '9')) || (character == ' ')))
                {
                    //error if contains anything else
                    return "Candidate Post Code can only contain characters, numbers, spaces";
                }
            }

            //candidatePostCode NOT LESS THAN 6 LENGTH (OR BLANK)
            if (candidatePostCode.Length < 6) { return "Candidate Post Code can not have less than 6 characters"; }

            //candidatePostCode NOT MORE THAN 200 LENGTH
            if (candidatePostCode.Length > 9) { return "Candidate Post Code can not have more than 9 characters"; }

            /******************************* Tests for CandidatePhone ******************************/

            //traverse the characters in the CandidatePhone
            foreach (char character in candidatePhone)
            {
                //CHECK EACH CandidatePhone CHARACTER IS ONLY NUMBER
                if (!((character >= '0') && (character <= '9')))
                {
                    //error if contains anything else
                    return "Candidate Phone can only contain numbers";
                }
            }

            //candidatePhone NOT LESS THAN 10 LENGTH (OR BLANK)
            if (candidatePhone.Length < 10) { return "Candidate Phone can not have less than 7 digits"; }

            //candidatePhone NOT MORE THAN 14 LENGTH
            if (candidatePhone.Length > 14) { return "Candidate Phone can not have more than 14 digits"; }



            ///******************************* Tests for CandidateEmail ******************************/
            //keeps a count of the @ characters in email
            int atCount = 0;
            //traverse the characters in the CandidateEmail
            foreach (char character in candidateEmail)
            {
              
                //CHECK EACH CandidateEmail CHARACTER IS ONLY NUMBER OR CHARACTER OR AT-SYMBOL OR FULL-STOP
                if (!(((character >= 'A') && (character <= 'z')) || ((character >= '0') && (character <= '9')) || (character == '@') || (character == '.')))
                {
                    //error if contains anything else
                    return "Candidate Email can only contain numbers, letters, ' @ ' or ' . ' ";
                }
                //CHECK ONLY ONE AT-SYMBOL IN EMAIL
                if (character == '@')
                {
                    //each time CandidateEmail character IS ' @ ' increment atCount
                    atCount++;
                }


            }
            //CHECK IF MORE THAN 1 AT-SYMBOL OR NO AT-SYMBOL
            if ((atCount > 1) || (atCount == 0)) { return "Candidate Email is not in correct format"; }
            //candidateEmail NOT LESS THAN 7 LENGTH (OR BLANK)
            if (candidateEmail.Length < 7) { return "Candidate Email can not have less than 7 characters"; }

            //candidatePhone NOT MORE THAN 200 LENGTH
            if (candidateEmail.Length > 100) { return "Candidate Email can not have more than 100 characters"; }



            /******************************* Tests for CandidateUsername ******************************/


            //traverse the characters in the name
            foreach (char character in candidateUsername)
            {
                //CHECK CandidateUsername IS ONLY CHARACTERS OR NUMBERS
                if (!(((character >= 'A') && (character <= 'z')) || ((character >= '0') && (character <= '9'))))
                {
                    //error if not a character or number or space
                    return "Candidate Username can only contain characters, numbers or spaces";
                }
            }

            //candidateUsername NOT LESS THAN 3 LENGTH (OR BLANK)
            if (candidateUsername.Length < 10) { return "Candidate Usernamee can not have less than 10 characters"; }

            //candidateLastName NOT MORE THAN 30 LENGTH
            if (candidateUsername.Length > 30) { return "Candidate Usernamee can not have more than 30 characters"; }


            /******************************* Tests for CandidatePassword ******************************/


            //traverse the characters in the name
            foreach (char character in candidatePassword)
            {
                //CHECK CandidatePassword IS ONLY CHARACTERS OR NUMBERS OR SPACE
                if (!(((character >= 'A') && (character <= 'z')) || ((character >= '0') && (character <= '9'))))
                {
                    //error if not a character or number or space
                    return "Candidate Password can only contain characters, numbers or spaces";
                }
            }

            //CandidatePassword NOT LESS THAN 3 LENGTH (OR BLANK)
            if (candidatePassword.Length < 10) { return "Candidate Password can not have less than 10 characters"; }

            //CandidatePassword NOT MORE THAN 30 LENGTH
            if (candidatePassword.Length > 30) { return "Candidate Password can not have more than 30 characters"; }

            //the CandidatePassword MUST BE SAME AS CandidateConfirmPassword
            if(candidateConfirmPassword != candidatePassword) { return "Candidate Password and Confirm Password must be the same"; }


            /////******************************* Tests for CandidateSecurityAnswer ******************************/


            //traverse the characters in the name
            foreach (char character in candidateSecurityAnswer)
            {
                //CHECK CandidateSecurityAnswer IS ONLY CHARACTERS OR NUMBERS OR SPACE
                if (!(((character >= 'A') && (character <= 'z')) || ((character >= '0') && (character <= '9')) || (character == ' ')))
                {
                    //error if not a character or number or space
                    return "Candidate Security Answer can only contain characters, numbers or spaces";
                }
            }

            //CandidatePassword NOT LESS THAN 3 LENGTH (OR BLANK)
            if (candidateSecurityAnswer.Length < 10) { return "Candidate Security Answer can not have less than 10 characters"; }

            //CandidatePassword NOT MORE THAN 30 LENGTH
            if (candidateSecurityAnswer.Length > 30) { return "Candidate Security Answer can not have more than 30 characters"; }


            ///******************************* Tests for CandidateDateRegistered ******************************/

            //CHECK CandidateDateRegistered IS A DATE (AND CORRECT FORMAT)
            try
            {
                //DateTime to convert/store the CandidateDateRegistered in DateTime variable, check its a date
                DateTime registrationDate = Convert.ToDateTime(candidateDateRegistered);

                //candidateBirthDate NOT LESS THAN 1/1/2020 (MIN)
                if (registrationDate < Convert.ToDateTime("2020/01/01"))
                {
                    return "Candidate Date Registered can not be less than 01/01/2020";
                }
                //CandidateDateRegistered NOT IN FUTURE- TODAY (MAX)
                if (registrationDate > DateTime.Today)
                {
                    return "Candidate Date Registered can not be in future";
                }
            }
            catch
            {
                //error if registrationDate is not a date
                return "Candidate Date Registered is not a date";
            }

            //if no problems then return blank
            return "";
        }
    }
}