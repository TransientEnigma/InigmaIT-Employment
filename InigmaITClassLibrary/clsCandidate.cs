using System;

namespace InigmaITClassLibrary
{
    public class clsCandidate
    {
        public clsCandidate()
        {
        }
        public string candidateNo { get; set; }
        public string candidateTitle { get; set; }
        public string candidateFirstName { get; set; }
        public string candidateLastName { get; set; }
        public string candidateBirthDate { get; set; }
        public string candidateAddress { get; set; }
        public string candidatePhone { get; set; }
        public string candidateEmail { get; set; }
        public string candidateUsername { get; set; }
        public string candidatePassword { get; set; }
        public string candidateSecurityAnswer { get; set; }
        public string candidateDateRegistered { get; set; }


        public string CandidateValidation(string candidateNo, 
                                            string candidateTitle, 
                                            string candidateFirstName,
                                            string candidateLastName, 
                                            string candidateBirthDate, 
                                            string candidateAddress, 
                                            string candidatePhone, 
                                            string candidateEmail,
                                            string candidateUsername,
                                            string candidatePassword, 
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


            ///******************************* Tests for CandidatePhone ******************************/

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
            if (candidateEmail.Length > 200) { return "Candidate Email can not have more than 200 characters"; }



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
            if (candidateSecurityAnswer.Length < 10) { return "Candidate Security Answer can not have less than 3 characters"; }

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