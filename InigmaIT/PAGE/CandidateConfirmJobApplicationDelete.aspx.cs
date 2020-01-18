using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InigmaIT.HTML
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CandidateConfirmJobApplicationDeleteHomePageTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void CandidateConfirmJobApplicationDeleteAboutUsTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }

        protected void CandidateConfirmJobApplicationDeleteRegistrationTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateHomePage.aspx");
        }

        protected void CandidateConfirmJobApplicationDeleteJobSearchTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }

        protected void CandidateConfirmJobApplicationDeleteContactUsTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }

        protected void CandidateConfirmJobApplicationDeleteLoginTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectLogin.aspx");
        }

        protected void CandidateConfirmJobApplicationDeleteHomePageBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void CandidateConfirmJobApplicationDeleteAboutUsBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }

        protected void CandidateConfirmJobApplicationDeleteRegistrationBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateHomePage.aspx");
        }

        protected void CandidateConfirmJobApplicationDeleteJobSearchBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }

        protected void CandidateConfirmJobApplicationDeleteContactUsBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }

        protected void CandidateConfirmJobApplicationDeleteLoginBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectLogin.aspx");
        }

        protected void CandidateConfirmJobApplicationDeleteOK_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateJobApplicationDeleteConfirmation.aspx");
        }

        protected void CandidateConfirmJobApplicationDeleteCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateJobApplications.aspx");
        }
    }
}