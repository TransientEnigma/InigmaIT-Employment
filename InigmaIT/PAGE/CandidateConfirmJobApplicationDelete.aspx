<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CandidateConfirmJobApplicationDelete.aspx.cs" Inherits="InigmaIT.HTML.WebForm2" %>

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
                    <asp:LinkButton ID="CandidateConfirmJobApplicationDeleteHomePageTopLink" runat="server" OnClick="CandidateConfirmJobApplicationDeleteHomePageTopLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmJobApplicationDeleteAboutUsTopLink" runat="server" OnClick="CandidateConfirmJobApplicationDeleteAboutUsTopLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmJobApplicationDeleteRegistrationTopLink" runat="server" OnClick="CandidateConfirmJobApplicationDeleteRegistrationTopLink_Click">Candidate</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmJobApplicationDeleteJobSearchTopLink" runat="server" OnClick="CandidateConfirmJobApplicationDeleteJobSearchTopLink_Click">Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmJobApplicationDeleteContactUsTopLink" runat="server" OnClick="CandidateConfirmJobApplicationDeleteContactUsTopLink_Click">Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmJobApplicationDeleteLoginTopLink" runat="server" OnClick="CandidateConfirmJobApplicationDeleteLoginTopLink_Click">Login</asp:LinkButton></li>
            </ul>
        </nav>
    </header>
    <!--this section contains the main image-->
    <section class="CentredSpace">

        <div class ="JobApplicationsForm">
            <h1>Are you sure you want to delete the application?</h1>

                         <div class="JobApplicationsButtons">
                             <asp:Button ID="CandidateConfirmJobApplicationDeleteOK" runat="server" Text="OK" OnClick="CandidateConfirmJobApplicationDeleteOK_Click" Height="40px" Width="100px" />
                             <asp:Button ID="CandidateConfirmJobApplicationDeleteCancel" runat="server" Text="Cancel" OnClick="CandidateConfirmJobApplicationDeleteCancel_Click" Height="40px" Width="100px" />
                    </div>
        </div>
        

    </section>
    <!--this section contains info. searcheable by search engines-->
 
    <!--footer contains loogo banner image and the links to other pages/ same as header but no image-->
    <footer>
        <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="CandidateConfirmJobApplicationDeleteHomePageBotLink" runat="server" OnClick="CandidateConfirmJobApplicationDeleteHomePageBotLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmJobApplicationDeleteAboutUsBotLink" runat="server" OnClick="CandidateConfirmJobApplicationDeleteAboutUsBotLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmJobApplicationDeleteRegistrationBotLink" runat="server" OnClick="CandidateConfirmJobApplicationDeleteRegistrationBotLink_Click">Candidate</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmJobApplicationDeleteJobSearchBotLink" runat="server" OnClick="CandidateConfirmJobApplicationDeleteJobSearchBotLink_Click">Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmJobApplicationDeleteContactUsBotLink" runat="server" OnClick="CandidateConfirmJobApplicationDeleteContactUsBotLink_Click">Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateConfirmJobApplicationDeleteLoginBotLink" runat="server" OnClick="CandidateConfirmJobApplicationDeleteLoginBotLink_Click">Login</asp:LinkButton></li>
            </ul>
        </nav>
    </footer>
    <!--the section contains info. searcheable by search engines-->
    <section>
        <div>
            <p class="bottom">
                Janzeb Masiano the proprietor of InigmaIT &reg; Employment UK recruitment services provider Based at 48 Winifred Avenue, Earlsdon Coventry CV5 6JS
                <br />Inigma Employment © Copywrite <% lblCandidateConfirmJobApplicationDeleteYear.Text = Convert.ToString(DateTime.Today.Year); %><asp:Label ID="lblCandidateConfirmJobApplicationDeleteYear" runat="server" Text="Label"></asp:Label>
            </p>

        </div>
    </section>
    </form>
</body>
</html>
