using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InigmaIT.PAGE
{
    public partial class CandidateJobApplications : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void CandidateJobApplicationsHomePageTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void CandidateJobApplicationsAboutUsTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }

        protected void CandidateJobApplicationsRegistrationTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateHomePage.aspx");
        }

        protected void CandidateJobApplicationsJobSearchTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }

        protected void CandidateJobApplicationsContactUsTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }

        protected void CandidateJobApplicationsLoginTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectLogin.aspx");
        }

        protected void CandidateJobApplicationsHomePageBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void CandidateJobApplicationsAboutUsBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }

        protected void CandidateJobApplicationsRegistrationBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateHomePage.aspx");
        }

        protected void CandidateJobApplicationsJobSearchBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }

        protected void CandidateJobApplicationsContactUsBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }

        protected void CandidateJobApplicationsLoginBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectLogin.aspx");
        }
        protected void CandidateJobApplicationsDeleteApplication_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateConfirmJobApplicationDelete.aspx");
        }
    }
}