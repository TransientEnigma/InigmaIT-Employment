<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CandidateHomePage.aspx.cs" Inherits="InigmaIT.PAGE.CandidateHomePage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="stylesheet" href="../CSS/MainStyleSheet.css" />
        <link rel="stylesheet" href="../CSS/CandidateHomePage.css" />
    <title>Registration</title>
     <style type="text/css">
         .auto-style1 {
             height: 29px;
         }
     </style>
</head>
<body>
    <form id="form1" runat="server">
        <!--header contains loogo banner image and the links to other pages-->
    <header>
        <div class="SlimLogoHeaderImage"></div> <!--  <img src="../IMAGE/SlimLogoHeader.jpg" /> -->
       <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="CandidateHomePageHomePageTopLink" runat="server" OnClick="CandidateHomePageHomePageTopLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateHomePageAboutUsTopLink" runat="server" OnClick="CandidateHomePageAboutUsTopLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateHomePageRegistrationTopLink" runat="server" OnClick="CandidateHomePageRegistrationTopLink_Click" >Candidate</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateHomePageJobSearchTopLink" runat="server" OnClick="CandidateHomePageJobSearchTopLink_Click">Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateHomePageContactUsTopLink" runat="server" OnClick="CandidateHomePageContactUsTopLink_Click">Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateHomePageLoginTopLink" runat="server" OnClick="CandidateHomePageLoginTopLink_Click" >Logout</asp:LinkButton></li>
            </ul>
        </nav>
    </header>
    <!--this section contains the main image-->
    <section class="CentredSpace">

        <div class ="RegistrationForm">
            <h1>Candidate Home Page</h1>
             <!-- START REGISTRATION FORM-->
            <div class="RegistrationTable" >
                    <table border="0">
                        <tr><td>CandidateNo:</td><td>
                            <asp:Label ID="lblCandidateHomePageCandidateNo" runat="server" Height="25px" Width="300px"></asp:Label></td></tr>
                        <tr><td>Title:</td><td>
                            <asp:TextBox ID="txtCandidateeHomePageCandidateTitle" runat="server" Height="25px" Width="150px"></asp:TextBox></td></tr>
                        <tr><td>First Name:</td><td>
                            <asp:TextBox ID="txtCandidateHomePageCandidateFirstName" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>Last Name:</td><td>
                            <asp:TextBox ID="txtCandidateHomePageCandidateLastName" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>Address:</td><td>
                            <asp:TextBox ID="txtCandidateHomePageCandidateAddress" runat="server" Height="100px" Rows="5" TextMode="MultiLine" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>Post Code:</td><td>
                            <asp:TextBox ID="txtCandidateRegistrationCandidatePostCode" runat="server" Height="25px" Width="150px"></asp:TextBox></td></tr>
                        <tr><td>Date of Birth:</td><td>
                            <asp:TextBox ID="txtCandidateHomePageCandidateBirthDate" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>Phone:</td><td>
                            <asp:TextBox ID="txtCandidateHomePageCandidatePhone" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>E-mail:</td><td>
                            <asp:TextBox ID="txtCandidateHomePageCandidateEmail" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>Username:</td><td>
                            <asp:TextBox ID="txtCandidateRegistrationCandidateUserName" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                        <tr><td class="auto-style1">Password:</td><td class="auto-style1">
                            <asp:TextBox ID="txtCandidateHomePageCandidatePassword" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>Favourite Colour:</td><td>
                            <asp:TextBox ID="txtCandidateHomePageCandidateSecurityAnswer" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>CV File:</td><td>
                            <asp:FileUpload ID="fileCandidateHomePageCandidateCV" runat="server" Height="25px" Width="300px" /></td></tr>
                        <tr><td>Date Registered:</td><td>
                            <asp:Label ID="lblCandidateHomePageDateRegistered" runat="server" Height="25px" Width="300px"></asp:Label></td></tr>
                    </table>
            </div>
            <!-- END REGISTRATION FORM-->
                   <div class="RegistrationButtons">
                       <asp:Button ID="CandidateHomePageSaveDetails" runat="server" Text="Save" OnClick="CandidateHomePageSaveDetails_Click" Height="40px" Width="150px" />
                       <asp:Button ID="CandidateHomePageClearForm" runat="server" Text="Clear" OnClick="CandidateHomePageClearForm_Click" Height="40px" Width="150px" />
                       <asp:Button ID="CandidateHomePageViewApplications" runat="server" Text="View Applications" OnClick="CandidateHomePageViewApplications_Click" Height="40px" Width="150px" />
                       <asp:Button ID="CandidateHomePageDeleteAccount" runat="server" Text="Delete Account" OnClick="CandidateHomePageDeleteAccount_Click" Height="40px" Width="150px" />
                    </div>
        </div>
        

    </section>
    <!--this section contains info. searcheable by search engines-->
 
    <!--footer contains loogo banner image and the links to other pages/ same as header but no image-->
    <footer>
        <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="CandidateHomePageHomePageBotLink" runat="server" OnClick="CandidateHomePageHomePageBotLink_Click" >Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateHomePageAboutUsBotLink" runat="server" OnClick="CandidateHomePageAboutUsBotLink_Click" >About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateHomePageRegistrationBotLink" runat="server" OnClick="CandidateHomePageRegistrationBotLink_Click" >Candidate</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateHomePageJobSearchBotLink" runat="server" OnClick="CandidateHomePageJobSearchBotLink_Click" >Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateHomePageContactUsBotLink" runat="server" OnClick="CandidateHomePageContactUsBotLink_Click" >Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateHomePageLoginBotLink" runat="server" OnClick="CandidateHomePageLoginBotLink_Click">Logout</asp:LinkButton></li>
            </ul>
        </nav>
    </footer>
    <!--the section contains info. searcheable by search engines-->
    <section>
        <div>
            <p class="bottom">
                Janzeb Masiano the proprietor of InigmaIT &reg; Employment UK recruitment services provider Based at 48 Winifred Avenue, Earlsdon Coventry CV5 6JS
                <br />Inigma Employment © Copywrite <% lblCandidateHomePageHomePageYear.Text = Convert.ToString(DateTime.Today.Year); %><asp:Label ID="lblCandidateHomePageHomePageYear" runat="server" Text="Label"></asp:Label>
            </p>

        </div>
    </section>
    </form>
</body>
</html>
