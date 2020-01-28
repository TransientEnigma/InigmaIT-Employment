using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InigmaITClassLibrary;

namespace InigmaIT.PAGE
{
    public partial class CandidateHomePage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ////create and instance of clsCandidateCollection to access the CandidateList data
            clsCandidateCollection retrievedCollection = new clsCandidateCollection();

            //integer to store the index for the candidatelist retrieved
            Int32 index = 0;

            //get the CandidateNo of the candidate in the list indexed by index
            lblCandidateHomePageCandidateNo.Text = Convert.ToString(retrievedCollection.CandidateList[index].CandidateNo);
            //get the CandidateTitle of the candidate in the list indexed by index
            txtCandidateeHomePageCandidateTitle.Text = Convert.ToString(retrievedCollection.CandidateList[index].CandidateTitle);
            //get the CandidateFirstName of the candidate in the list indexed by index
            txtCandidateHomePageCandidateFirstName.Text = Convert.ToString(retrievedCollection.CandidateList[index].CandidateFirstName);
            //get the CandidateLastName of the candidate in the list indexed by index
            txtCandidateHomePageCandidateLastName.Text = Convert.ToString(retrievedCollection.CandidateList[index].CandidateLastName);
            //get the CandidateAddress of the candidate in the list indexed by index
            txtCandidateHomePageCandidateAddress.Text = Convert.ToString(retrievedCollection.CandidateList[index].CandidateAddress);
            //get the CandidatePostCode of the candidate in the list indexed by index
            txtCandidateRegistrationCandidatePostCode.Text = Convert.ToString(retrievedCollection.CandidateList[index].CandidatePostCode);
            //get the CandidateBirthDate of the candidate in the list indexed by index
            txtCandidateHomePageCandidateBirthDate.Text = Convert.ToString(retrievedCollection.CandidateList[index].CandidateBirthDate);
            //get the CandidatePhone of the candidate in the list indexed by index
            txtCandidateHomePageCandidatePhone.Text = Convert.ToString(retrievedCollection.CandidateList[index].CandidatePhone);
            //get the CandidateEmail of the candidate in the list indexed by index
            txtCandidateHomePageCandidateEmail.Text = Convert.ToString(retrievedCollection.CandidateList[index].CandidateEmail);
            //get the CandidateUsername of the candidate in the list indexed by index
            txtCandidateRegistrationCandidateUsername.Text = Convert.ToString(retrievedCollection.CandidateList[index].CandidateUsername);
            //get the CandidatePassword of the candidate in the list indexed by index
            //txtCandidateHomePageCandidatePassword.Text = Convert.ToString(retrievedCollection.CandidateList[index].CandidatePassword);
            //get the CandidateSecurityAnswer of the candidate in the list indexed by index
            //txtCandidateHomePageCandidateSecurityAnswer.Text = Convert.ToString(retrievedCollection.CandidateList[index].CandidateSecurityAnswer);
            //get the CandidateDateRegistered of the candidate in the list indexed by index, format the date
            lblCandidateHomePageDateRegistered.Text = Convert.ToString(retrievedCollection.CandidateList[index].CandidateDateRegistered.Date.Day 
                                                                       + "/" 
                                                                       + retrievedCollection.CandidateList[index].CandidateDateRegistered.Date.Month 
                                                                       + "/" 
                                                                       + retrievedCollection.CandidateList[index].CandidateDateRegistered.Date.Year);
        }

        protected void CandidateHomePageHomePageTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void CandidateHomePageAboutUsTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }

        protected void CandidateHomePageRegistrationTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateHomePage.aspx");
        }

        protected void CandidateHomePageJobSearchTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }

        protected void CandidateHomePageContactUsTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }

        protected void CandidateHomePageLoginTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void CandidateHomePageHomePageBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void CandidateHomePageAboutUsBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }

        protected void CandidateHomePageRegistrationBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateHomePage.aspx");
        }

        protected void CandidateHomePageJobSearchBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }

        protected void CandidateHomePageContactUsBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }

        protected void CandidateHomePageLoginBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void CandidateHomePageSaveDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateSaveConfirmation.aspx");
        }

        protected void CandidateHomePageClearForm_Click(object sender, EventArgs e)
        {
            
        }

        protected void CandidateHomePageViewApplications_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateJobApplications.aspx");
        }

        protected void CandidateHomePageDeleteAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateConfirmDeleteAccount.aspx");
        }


    }
}