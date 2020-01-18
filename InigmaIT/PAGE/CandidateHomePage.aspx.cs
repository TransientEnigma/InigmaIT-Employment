using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InigmaIT.PAGE
{
    public partial class CandidateHomePage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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