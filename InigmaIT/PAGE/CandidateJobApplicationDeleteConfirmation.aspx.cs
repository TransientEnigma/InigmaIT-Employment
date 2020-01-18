using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InigmaIT.HTML
{
    public partial class CandidateJobApplicationDeleteConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CandidateJobApplicationDeleteConfirmationHomePageTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void CandidateJobApplicationDeleteConfirmationAboutUsTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }

        protected void CandidateJobApplicationDeleteConfirmationRegistrationTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void CandidateJobApplicationDeleteConfirmationJobSearchTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }

        protected void CandidateJobApplicationDeleteConfirmationContactUsTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }

        protected void CandidateJobApplicationDeleteConfirmationLoginTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectLogin.aspx");
        }

        protected void CandidateJobApplicationDeleteConfirmationHomeHomePageBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void CandidateJobApplicationDeleteConfirmationHomeAboutUsBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }

        protected void CandidateJobApplicationDeleteConfirmationHomeRegistrationBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void CandidateJobApplicationDeleteConfirmationHomeJobSearchBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }

        protected void CandidateJobApplicationDeleteConfirmationHomeContactUsBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }

        protected void CandidateJobApplicationDeleteConfirmationHomeLoginBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectLogin.aspx");
        }

        protected void CandidateJobApplicationDeleteConfirmationOK_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateJobApplications.aspx");
        }
    }
}