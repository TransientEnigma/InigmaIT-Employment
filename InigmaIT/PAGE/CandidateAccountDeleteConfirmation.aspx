<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CandidateAccountDeleteConfirmation.aspx.cs" Inherits="InigmaIT.HTML.CandidateAccountDeleteConfirmation" %>

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
                    <asp:LinkButton ID="CandidateAccountDeleteConfirmationHomePageTopLink" runat="server" OnClick="CandidateAccountDeleteConfirmationHomePageTopLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateAccountDeleteConfirmationAboutUsTopLink" runat="server" OnClick="CandidateAccountDeleteConfirmationAboutUsTopLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateAccountDeleteConfirmationRegistrationTopLink" runat="server" OnClick="CandidateAccountDeleteConfirmationRegistrationTopLink_Click">Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateAccountDeleteConfirmationJobSearchTopLink" runat="server" OnClick="CandidateAccountDeleteConfirmationJobSearchTopLink_Click">Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateAccountDeleteConfirmationContactUsTopLink" runat="server" OnClick="CandidateAccountDeleteConfirmationContactUsTopLink_Click">Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateAccountDeleteConfirmationLoginTopLink" runat="server" OnClick="CandidateAccountDeleteConfirmationLoginTopLink_Click">Login</asp:LinkButton></li>
            </ul>
        </nav>
    </header>
    <!--this section contains the main image-->
    <section class="CentredSpace">

        <div class="JobApplicationsForm">
            <h1>Your Account has been deleted.</h1>

            <div class="JobApplicationsButtons">
                <asp:Button ID="CandidateAccountDeleteConfirmationOK" runat="server" Text="OK" OnClick="CandidateAccountDeleteConfirmationOK_Click" Height="40px" Width="100px" />

            </div>
        </div>


    </section>
    <!--this section contains info. searcheable by search engines-->
    <!--footer contains loogo banner image and the links to other pages/ same as header but no image-->
    <footer>
        <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="CandidateAccountDeleteConfirmationHomePageBotLink" runat="server" OnClick="CandidateAccountDeleteConfirmationHomePageBotLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateAccountDeleteConfirmationAboutUsBotLink" runat="server" OnClick="CandidateAccountDeleteConfirmationAboutUsBotLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateAccountDeleteConfirmationRegistrationBotLink" runat="server" OnClick="CandidateAccountDeleteConfirmationRegistrationBotLink_Click">Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateAccountDeleteConfirmationJobSearchBotLink" runat="server" OnClick="CandidateAccountDeleteConfirmationJobSearchBotLink_Click">Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateAccountDeleteConfirmationContactUsBotLink" runat="server" OnClick="CandidateAccountDeleteConfirmationContactUsBotLink_Click">Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateAccountDeleteConfirmationLoginBotLink" runat="server" OnClick="CandidateAccountDeleteConfirmationLoginBotLink_Click">Login</asp:LinkButton></li>
            </ul>
        </nav>
    </footer>
    <!--the section contains info. searcheable by search engines-->
    <section>
        <div>
            <p class="bottom">
                Janzeb Masiano the proprietor of InigmaIT &reg; Employment UK recruitment services provider Based at 48 Winifred Avenue, Earlsdon Coventry CV5 6JS
                <br />Inigma Employment © Copywrite <% lblCandidateAccountDeleteConfirmationYear.Text = Convert.ToString(DateTime.Today.Year); %><asp:Label ID="lblCandidateAccountDeleteConfirmationYear" runat="server" Text="Label"></asp:Label>
            </p>

        </div>
    </section>
    </form>
</body>
</html>
