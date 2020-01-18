using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InigmaIT.HTML
{
    public partial class CandidateConfirmDeleteAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void CandidateConfirmDeleteAccountHomePageTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void CandidateConfirmDeleteAccountAboutUsTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }

        protected void CandidateConfirmDeleteAccountRegistrationTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void CandidateConfirmDeleteAccountJobSearchTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }

        protected void CandidateConfirmDeleteAccountContactUsTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }

        protected void CandidateConfirmDeleteAccountLoginTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void CandidateConfirmDeleteAccountHomePageBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void CandidateConfirmDeleteAccountAboutUsBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }

        protected void CandidateConfirmDeleteAccountRegistrationBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void CandidateConfirmDeleteAccountJobSearchBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }

        protected void CandidateConfirmDeleteAccountContactUsBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }

        protected void CandidateConfirmDeleteAccountLoginBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void CandidateConfirmDeleteAccountOK_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateAccountDeleteConfirmation.aspx");
        }

        protected void CandidateConfirmDeleteAccountCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateHomePage.aspx");
        }
    }
}