<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CandidateConfirmDeleteAccount.aspx.cs" Inherits="InigmaIT.HTML.CandidateConfirmDeleteAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link rel="stylesheet" href="../CSS/MainStyleSheet.css" />
        <link rel="stylesheet" href="../CSS/CandidateConfirmDeleteAccount.css" />
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
                    <asp:LinkButton ID="CandidateConfirmDeleteAccountHomePageTopLink" runat="server" OnClick="CandidateConfirmDeleteAccountHomePageTopLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmDeleteAccountAboutUsTopLink" runat="server" OnClick="CandidateConfirmDeleteAccountAboutUsTopLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmDeleteAccountRegistrationTopLink" runat="server" OnClick="CandidateConfirmDeleteAccountRegistrationTopLink_Click">Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmDeleteAccountJobSearchTopLink" runat="server" OnClick="CandidateConfirmDeleteAccountJobSearchTopLink_Click">Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmDeleteAccountContactUsTopLink" runat="server" OnClick="CandidateConfirmDeleteAccountContactUsTopLink_Click">Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmDeleteAccountLoginTopLink" runat="server" OnClick="CandidateConfirmDeleteAccountLoginTopLink_Click">Logout</asp:LinkButton></li>
            </ul>
        </nav>
    </header>
    <!--this section contains the main image-->
    <section class="CentredSpace">

        <div class ="JobApplicationsForm">
            <h1>Are you sure you want to delete your account?</h1>

                         <div class="JobApplicationsButtons">
                             <asp:Button ID="CandidateConfirmDeleteAccountOK" runat="server" Text="OK" OnClick="CandidateConfirmDeleteAccountOK_Click" Height="40px" Width="100px" />
                             <asp:Button ID="CandidateConfirmDeleteAccountCancel" runat="server" Text="Cancel" OnClick="CandidateConfirmDeleteAccountCancel_Click" Height="40px" Width="100px" />
                    </div>
        </div>
        

    </section>
    <!--this section contains info. searcheable by search engines-->
 
    <!--footer contains loogo banner image and the links to other pages/ same as header but no image-->
    <footer>
        <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="CandidateConfirmDeleteAccountHomePageBotLink" runat="server" OnClick="CandidateConfirmDeleteAccountHomePageBotLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmDeleteAccountAboutUsBotLink" runat="server" OnClick="CandidateConfirmDeleteAccountAboutUsBotLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmDeleteAccountRegistrationBotLink" runat="server" OnClick="CandidateConfirmDeleteAccountRegistrationBotLink_Click">Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmDeleteAccountJobSearchBotLink" runat="server" OnClick="CandidateConfirmDeleteAccountJobSearchBotLink_Click" >Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmDeleteAccountContactUsBotLink" runat="server" OnClick="CandidateConfirmDeleteAccountContactUsBotLink_Click" >Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmDeleteAccountLoginBotLink" runat="server" OnClick="CandidateConfirmDeleteAccountLoginBotLink_Click" >Logout</asp:LinkButton></li>
            </ul>
        </nav>
    </footer>
    <!--the section contains info. searcheable by search engines-->
    <section>
        <div>
            <p class="bottom">
                Janzeb Masiano the proprietor of InigmaIT &reg; Employment UK recruitment services provider Based at 48 Winifred Avenue, Earlsdon Coventry CV5 6JS
                <br />Inigma Employment © Copywrite <% lblCandidateConfirmDeleteAccountYear.Text = Convert.ToString(DateTime.Today.Year); %><asp:Label ID="lblCandidateConfirmDeleteAccountYear" runat="server" Text="Label"></asp:Label>
            </p>

        </div>
    </section>
    </form>
</body>
</html>
