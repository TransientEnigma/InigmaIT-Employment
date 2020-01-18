using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InigmaIT.HTML
{
    public partial class CandidateAccountDeleteConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CandidateAccountDeleteConfirmationOK_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void CandidateAccountDeleteConfirmationHomePageTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void CandidateAccountDeleteConfirmationAboutUsTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }

        protected void CandidateAccountDeleteConfirmationRegistrationTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateRegistration.aspx");
        }

        protected void CandidateAccountDeleteConfirmationJobSearchTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }

        protected void CandidateAccountDeleteConfirmationContactUsTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }

        protected void CandidateAccountDeleteConfirmationLoginTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectLogin.aspx");
        }

        protected void CandidateAccountDeleteConfirmationHomePageBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void CandidateAccountDeleteConfirmationAboutUsBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }

        protected void CandidateAccountDeleteConfirmationRegistrationBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateRegistration.aspx");
        }

        protected void CandidateAccountDeleteConfirmationJobSearchBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }

        protected void CandidateAccountDeleteConfirmationContactUsBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }

        protected void CandidateAccountDeleteConfirmationLoginBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectLogin.aspx");
        }
    }
}