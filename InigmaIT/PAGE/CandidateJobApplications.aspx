<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CandidateJobApplications.aspx.cs" Inherits="InigmaIT.PAGE.CandidateJobApplications" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="stylesheet" href="../CSS/MainStyleSheet.css" />
        <link rel="stylesheet" href="../CSS/JobApplicationsPage.css" />
    <title>Registration</title>
</head>
<body>
    <form id="form1" runat="server">
       <!--header contains loogo banner image and the links to other pages-->
    <header>
        <div class="SlimLogoHeaderImage"></div> <!--  <img src="../IMAGE/SlimLogoHeader.jpg" /> -->
        <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationsHomePageTopLink" runat="server" OnClick="CandidateJobApplicationsHomePageTopLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationsAboutUsTopLink" runat="server" OnClick="CandidateJobApplicationsAboutUsTopLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationsRegistrationTopLink" runat="server" OnClick="CandidateJobApplicationsRegistrationTopLink_Click">Candidate</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationsJobSearchTopLink" runat="server" OnClick="CandidateJobApplicationsJobSearchTopLink_Click">Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationsContactUsTopLink" runat="server" OnClick="CandidateJobApplicationsContactUsTopLink_Click">Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationsLoginTopLink" runat="server" OnClick="CandidateJobApplicationsLoginTopLink_Click">Login</asp:LinkButton></li>
            </ul>
        </nav>
    </header>
    <!--this section contains the main image-->
    <section class="CentredSpace">

        <div class ="JobApplicationsForm">
            <h1>Job Applications List</h1>
            <!-- START REGISTRATION FORM-->
            <div class="JobApplicationsTable" >
                    <table border="0">
                        <tr><th> &nbsp &nbsp | &nbsp &nbsp Job Application No &nbsp &nbsp &nbsp &nbsp  </th><th>| &nbsp &nbsp &nbsp &nbsp  &nbsp &nbsp  &nbsp &nbsp Job Name &nbsp &nbsp  &nbsp &nbsp  &nbsp &nbsp  &nbsp &nbsp </th><th>| &nbsp &nbsp &nbsp &nbsp Application Date &nbsp &nbsp  &nbsp &nbsp|</th> </tr>
                    </table>
                    <textarea class="JobApplicationsList" id="txtJobApplicationDetailsList"></textarea>

            </div>
            <!-- END REGISTRATION FORM-->
                                                <div class="JobApplicationsButtons">
                                                    <asp:Button ID="btnCandidateJobApplicationsDeleteApplication" runat="server" Text="Delete Application" OnClick="CandidateJobApplicationsDeleteApplication_Click" Height="40px" Width="200px" />
                                                    <asp:Button ID="btnCandidateJobApplicationsViewJobAppliedFor" runat="server" Text="View Job Applied For" Height="40px" Width="200px" />
                    </div>
        </div>
        

    </section>
    <!--this section contains info. searcheable by search engines-->
 
    <!--footer contains loogo banner image and the links to other pages/ same as header but no image-->
    <footer>
        <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationsHomePageBotLink" runat="server" OnClick="CandidateJobApplicationsHomePageBotLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationsAboutUsBotLink" runat="server" OnClick="CandidateJobApplicationsAboutUsBotLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationsRegistrationBotLink" runat="server" OnClick="CandidateJobApplicationsRegistrationBotLink_Click">Candidate</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationsJobSearchBotLink" runat="server" OnClick="CandidateJobApplicationsJobSearchBotLink_Click">Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationsContactUsBotLink" runat="server" OnClick="CandidateJobApplicationsContactUsBotLink_Click">Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationsLoginBotLink" runat="server" OnClick="CandidateJobApplicationsLoginBotLink_Click">Login</asp:LinkButton></li>
            </ul>
        </nav>
    </footer>
    <!--the section contains info. searcheable by search engines-->
    <section>
        <div>
            <p class="bottom">
                Janzeb Masiano the proprietor of InigmaIT &reg; Employment UK recruitment services provider Based at 48 Winifred Avenue, Earlsdon Coventry CV5 6JS
                <br />Inigma Employment © Copywrite <% lblCandidateJobApplicationsYear.Text = Convert.ToString(DateTime.Today.Year); %><asp:Label ID="lblCandidateJobApplicationsYear" runat="server" Text="Label"></asp:Label>
            </p>

        </div>
    </section>
    </form>
</body>
</html>
