<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CandidateJobApplicationDeleteConfirmation.aspx.cs" Inherits="InigmaIT.HTML.CandidateJobApplicationDeleteConfirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="../CSS/MainStyleSheet.css" />
    <link rel="stylesheet" href="../CSS/ConfirmationPage.css" />
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
                    <asp:LinkButton ID="CandidateJobApplicationDeleteConfirmationHomePageTopLink" runat="server" OnClick="CandidateJobApplicationDeleteConfirmationHomePageTopLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationDeleteConfirmationAboutUsTopLink" runat="server" OnClick="CandidateJobApplicationDeleteConfirmationAboutUsTopLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationDeleteConfirmationRegistrationTopLink" runat="server" OnClick="CandidateJobApplicationDeleteConfirmationRegistrationTopLink_Click">Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationDeleteConfirmationJobSearchTopLink" runat="server" OnClick="CandidateJobApplicationDeleteConfirmationJobSearchTopLink_Click">Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationDeleteConfirmationContactUsTopLink" runat="server" OnClick="CandidateJobApplicationDeleteConfirmationContactUsTopLink_Click">Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationDeleteConfirmationLoginTopLink" runat="server" OnClick="CandidateJobApplicationDeleteConfirmationLoginTopLink_Click">Login</asp:LinkButton></li>
            </ul>
        </nav>
      </header>
    <!--this section contains the main image-->
    <section class="CentredSpace">

        <div class="JobApplicationsForm">
            <h1>Your Job Application has been deleted.</h1>

            <div class="JobApplicationsButtons">
                <asp:Button ID="CandidateJobApplicationDeleteConfirmationOK" runat="server" Text="OK" OnClick="CandidateJobApplicationDeleteConfirmationOK_Click" Height="40px" Width="100px" />

            </div>
        </div>


    </section>
    <!--this section contains info. searcheable by search engines-->
    <!--footer contains loogo banner image and the links to other pages/ same as header but no image-->
    <footer>
        <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationDeleteConfirmationHomeHomePageBotLink" runat="server" OnClick="CandidateJobApplicationDeleteConfirmationHomeHomePageBotLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationDeleteConfirmationHomeAboutUsBotLink" runat="server" OnClick="CandidateJobApplicationDeleteConfirmationHomeAboutUsBotLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationDeleteConfirmationHomeRegistrationBotLink" runat="server" OnClick="CandidateJobApplicationDeleteConfirmationHomeRegistrationBotLink_Click">Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationDeleteConfirmationHomeJobSearchBotLink" runat="server" OnClick="CandidateJobApplicationDeleteConfirmationHomeJobSearchBotLink_Click">Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationDeleteConfirmationHomeContactUsBotLink" runat="server" OnClick="CandidateJobApplicationDeleteConfirmationHomeContactUsBotLink_Click">Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateJobApplicationDeleteConfirmationHomeLoginBotLink" runat="server" OnClick="CandidateJobApplicationDeleteConfirmationHomeLoginBotLink_Click">Login</asp:LinkButton></li>
            </ul>
        </nav>
    </footer>
    <!--the section contains info. searcheable by search engines-->
    <section>
        <div>
            <p class="bottom">
                Janzeb Masiano the proprietor of InigmaIT &reg; Employment UK recruitment services provider Based at 48 Winifred Avenue, Earlsdon Coventry CV5 6JS
                <br />Inigma Employment © Copywrite <% lblCandidateJobApplicationDeleteConfirmationYear.Text = Convert.ToString(DateTime.Today.Year); %><asp:Label ID="lblCandidateJobApplicationDeleteConfirmationYear" runat="server" Text="Label"></asp:Label>
            </p>

        </div>
    </section>
    </form>
</body>
</html>
