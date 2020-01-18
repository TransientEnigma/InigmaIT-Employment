<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CandidateSaveConfirmation.aspx.cs" Inherits="InigmaIT.HTML.CandidateSaveConfirmation" %>

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
        <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="CandidateSaveConfirmationHomePageTopLink" runat="server" OnClick="CandidateSaveConfirmationHomePageTopLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateSaveConfirmationAboutUsTopLink" runat="server" OnClick="CandidateSaveConfirmationAboutUsTopLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateSaveConfirmationRegistrationTopLink" runat="server" OnClick="CandidateSaveConfirmationRegistrationTopLink_Click">Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateSaveConfirmationJobSearchTopLink" runat="server" OnClick="CandidateSaveConfirmationJobSearchTopLink_Click">Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateSaveConfirmationContactUsTopLink" runat="server" OnClick="CandidateSaveConfirmationContactUsTopLink_Click">Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateSaveConfirmationLoginTopLink" runat="server" OnClick="CandidateSaveConfirmationLoginTopLink_Click">Login</asp:LinkButton></li>
            </ul>
        </nav>
        </nav>
    </header>
    <!--this section contains the main image-->
    <section class="CentredSpace">

        <div class ="JobApplicationsForm">
            <h1>Your details have been saved.</h1>

                         <div class="JobApplicationsButtons">
                             <asp:Button ID="CandidateSaveConfirmationOK" runat="server" Text="OK" OnClick="CandidateSaveConfirmationOK_Click" Height="40px" Width="100px" />

                    </div>
        </div>
        

    </section>
    <!--this section contains info. searcheable by search engines-->
 
    <!--footer contains loogo banner image and the links to other pages/ same as header but no image-->
    <footer>
        <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="CandidateSaveConfirmationHomePageBotLink" runat="server" OnClick="CandidateSaveConfirmationHomePageBotLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateSaveConfirmationAboutUsBotLink" runat="server" OnClick="CandidateSaveConfirmationAboutUsBotLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateSaveConfirmationRegistrationBotLink" runat="server" OnClick="CandidateSaveConfirmationRegistrationBotLink_Click">Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateSaveConfirmationJobSearchBotLink" runat="server" OnClick="CandidateSaveConfirmationJobSearchBotLink_Click">Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateSaveConfirmationContactUsBotLink" runat="server" OnClick="CandidateSaveConfirmationContactUsBotLink_Click">Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateSaveConfirmationLoginBotLink" runat="server" OnClick="CandidateSaveConfirmationLoginBotLink_Click">Login</asp:LinkButton></li>
            </ul>
        </nav>
    </footer>
    <!--the section contains info. searcheable by search engines-->
    <section>
        <div>
            <p class="bottom">
                Janzeb Masiano the proprietor of InigmaIT &reg; Employment UK recruitment services provider Based at 48 Winifred Avenue, Earlsdon Coventry CV5 6JS
                <br />Inigma Employment © Copywrite <% lblCandidateSaveConfirmationYear.Text = Convert.ToString(DateTime.Today.Year); %><asp:Label ID="lblCandidateSaveConfirmationYear" runat="server" Text="Label"></asp:Label>
            </p>

        </div>
    </section>
    </form>
</body>
</html>
