using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InigmaITClassLibrary;

namespace InigmaITEmployment.HTML
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if the date registration date is blank then add a date
            if(lblCandidateRegistrationDateRegistered.Text == "")
            {
                //put todays date in the textbox for registration date
                lblCandidateRegistrationDateRegistered.Text = Convert.ToString(DateTime.Today.Day) + "/" + Convert.ToString(DateTime.Today.Month) + "/" + Convert.ToString(DateTime.Today.Year);
            }  
            

        }



        //navigation buttons
        protected void RegistrationHomePageTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void RegistrationAboutUsTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }

        protected void RegistrationRegistrationTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateRegistration.aspx");
        }

        protected void RegistrationJobSearchTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }

        protected void RegistrationContactUsTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }

        protected void RegistrationLoginTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectLogin.aspx");
        }

        protected void RegistrationHomePageBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void RegistrationAboutUsBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }

        protected void RegistrationRegistrationBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateRegistration.aspx");
        }

        protected void RegistrationJobSearchBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }

        protected void RegistrationContactUsBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }

        protected void RegistrationLoginBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectLogin.aspx");
        }

        protected void BtnSaveDetails_Click(object sender, EventArgs e)
        {
            //string to store the validation error
            string validationError = "";
            

           
            //create instance of clsCandidate
            clsCandidate aCandidate = new clsCandidate();

            //assign the data to the validation method. We have no candidateNo for new candidates so just use "1"
            validationError = aCandidate.CandidateValidation("1", 
                                                    txtCandidateRegistrationCandidateTitle.Text, 
                                                    txtCandidateRegistrationCandidateFirstName.Text, 
                                                    txtCandidateRegistrationCandidateLastName.Text, 
                                                    txtCandidateRegistrationCandidateBirthDate.Text, 
                                                    txtCandidateRegistrationCandidateAddress.Text, 
                                                    txtCandidateRegistrationCandidatePostCode.Text, 
                                                    txtCandidateRegistrationCandidatePhone.Text, 
                                                    txtCandidateRegistrationCandidateEmail.Text, 
                                                    txtCandidateRegistrationCandidateUserName.Text, 
                                                    txtCandidateRegistrationCandidatePassword.Text, 
                                                    txtCandidateRegistrationCandidateSecurityAnswer.Text, 
                                                    lblCandidateRegistrationDateRegistered.Text);
            //if there are no validation errors
            if(validationError == "")
            {
                //register a new candidate (i.e. add the candidate to database)
                Response.Redirect("CandidateSaveConfirmation.aspx");
                //create an instance of clsCandidateCollection
                //clsCandidateCollection newCandidate = new clsCandidateCollection
                //pass in the data of someCandidate in the newCandidate object
                //newCandidate.someCandidate.Title = txtCandidateRegistrationCandidateTitle.Text;
                //newCandidate.someCandidate.CandidateFirstName = txtCandidateRegistrationCandidateFirstName.Text, 
                //newCandidate.someCandidate.CandidateLastName = txtCandidateRegistrationCandidateLastName.Text, 
                //newCandidate.someCandidate.CandidateBirthDate = txtCandidateRegistrationCandidateBirthDate.Text, 
                //newCandidate.someCandidate.CandidateAddress = txtCandidateRegistrationCandidateAddress.Text, 
                //newCandidate.someCandidate.CandidatePostCode = txtCandidateRegistrationCandidatePostCode.Text, 
                //newCandidate.someCandidate.CandidatePhone = txtCandidateRegistrationCandidatePhone.Text, 
                //newCandidate.someCandidate.CandidateEmail = txtCandidateRegistrationCandidateEmail.Text, 
                //newCandidate.someCandidate.CandidateUserName = txtCandidateRegistrationCandidateUserName.Text, 
                //newCandidate.someCandidate.CandidatePassword = txtCandidateRegistrationCandidatePassword.Text, 
                //newCandidate.someCandidate.CandidateSecurityAnswer = txtCandidateRegistrationCandidateSecurityAnswer.Text, 
                //newCandidate.someCandidate.CandidateDateRegistered = lblCandidateRegistrationDateRegistered.Text

                //execute the AddCandidate method, to add a new candidate to database
                //newCandidate.AddCandidate();


            }
            //if there is a validation error
            if (validationError != "")
            {
                //display validation error
                lblCandidateRegistrationValidationError.Text = validationError;
            }


        }
    }
}