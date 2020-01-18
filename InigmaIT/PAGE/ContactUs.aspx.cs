using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InigmaIT.HTML
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ContactUsHomePageTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void ContactUsAboutUsTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }

        protected void ContactUsRegistrationTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateRegistration.aspx");
        }

        protected void ContactUsJobSearchTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }

        protected void ContactUsContactUsTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }

        protected void ContactUsLoginTopLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectLogin.aspx");
        }

        protected void ContactUsHomePageBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void ContactUsAboutUsBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }

        protected void ContactUsRegistrationBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("CandidateRegistration.aspx");
        }

        protected void ContactUsJobSearchBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }

        protected void ContactUsContactUsBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }

        protected void ContactUsLoginBotLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectLogin.aspx");
        }
    }
}