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
            //for security we hide the CandidateNo
            lblCandidateRegistrationCandidateNo.Visible = false;

            //if the date registration date is blank then add a date
            if (lblCandidateRegistrationDateRegistered.Text == "")
            {
                //put todays date in the textbox for registration date
                lblCandidateRegistrationDateRegistered.Text = Convert.ToString(DateTime.Today.Day) + "/" + Convert.ToString(DateTime.Today.Month) + "/" + Convert.ToString(DateTime.Today.Year);
            }

            
            lblCandidateRegistrationCandidateNo.Text = "0";
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
                                                    txtCandidateRegistrationCandidateConfirmPassword.Text,
                                                    txtCandidateRegistrationCandidateSecurityAnswer.Text, 
                                                    lblCandidateRegistrationDateRegistered.Text);
            //if there are no validation errors
            if(validationError == "")
            {

                //create an instance of clsCandidateCollection
                clsCandidateCollection theCandidateCollection = new clsCandidateCollection();
                //pass in the data of someCandidate in the newCandidate object
                theCandidateCollection.SomeCandidate.CandidateTitle = txtCandidateRegistrationCandidateTitle.Text;
                theCandidateCollection.SomeCandidate.CandidateFirstName = txtCandidateRegistrationCandidateFirstName.Text;
                theCandidateCollection.SomeCandidate.CandidateLastName = txtCandidateRegistrationCandidateLastName.Text;
                theCandidateCollection.SomeCandidate.CandidateBirthDate = Convert.ToDateTime(txtCandidateRegistrationCandidateBirthDate.Text);
                theCandidateCollection.SomeCandidate.CandidateAddress = txtCandidateRegistrationCandidateAddress.Text;
                theCandidateCollection.SomeCandidate.CandidatePostCode = txtCandidateRegistrationCandidatePostCode.Text;
                theCandidateCollection.SomeCandidate.CandidatePhone = txtCandidateRegistrationCandidatePhone.Text;
                theCandidateCollection.SomeCandidate.CandidateEmail = txtCandidateRegistrationCandidateEmail.Text;
                theCandidateCollection.SomeCandidate.CandidateUsername = txtCandidateRegistrationCandidateUserName.Text;
                theCandidateCollection.SomeCandidate.CandidatePassword = txtCandidateRegistrationCandidatePassword.Text;
                theCandidateCollection.SomeCandidate.CandidateSecurityAnswer = txtCandidateRegistrationCandidateSecurityAnswer.Text;
                theCandidateCollection.SomeCandidate.CandidateCVFile = "no file path";

                //execute the AddCandidate method, to add a new candidate to database
                if (theCandidateCollection.AddCandidate())
                {
                    //if the result of AddCandidate is true register 
                    Response.Redirect("CandidateSaveConfirmation.aspx");
                }
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