<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CandidateRegistration.aspx.cs" Inherits="InigmaITEmployment.HTML.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link rel="stylesheet" href="../CSS/MainStyleSheet.css" />
        <link rel="stylesheet" href="../CSS/CandidateRegistrationPage.css" />
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
                    <asp:LinkButton ID="CandidateRegistrationHomePageTopLink" runat="server" OnClick="RegistrationHomePageTopLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateRegistrationAboutUsTopLink" runat="server" OnClick="RegistrationAboutUsTopLink_Click"  >About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateRegistrationRegistrationTopLink" runat="server" OnClick="RegistrationRegistrationTopLink_Click" >Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateRegistrationJobSearchTopLink" runat="server" OnClick="RegistrationJobSearchTopLink_Click"  >Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateRegistrationContactUsTopLink" runat="server" OnClick="RegistrationContactUsTopLink_Click"  >Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateRegistrationLoginTopLink" runat="server" OnClick="RegistrationLoginTopLink_Click" >Login</asp:LinkButton></li>
            </ul>
        </nav>
    </header>
    <!--this section contains the main image-->
    <section class="CentredSpace">

        <div class ="RegistrationForm">
            <h1>Candidate Registration Details</h1>
            <!-- START REGISTRATION FORM-->
            <div class="RegistrationTable" >
                    <table border="0">
                        <tr><td>&nbsp;</td><td>
                            <asp:Label ID="lblCandidateRegistrationCandidateNo" runat="server" Height="25px" Width="300px"></asp:Label></td></tr>
                        <tr><td>Title:</td><td>
                            <asp:TextBox ID="txtCandidateRegistrationCandidateTitle" runat="server" Height="25px" Width="150px"></asp:TextBox></td></tr>
                        <tr><td>First Name:</td><td>
                            <asp:TextBox ID="txtCandidateRegistrationCandidateFirstName" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>Last Name:</td><td>
                            <asp:TextBox ID="txtCandidateRegistrationCandidateLastName" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>Address:</td><td>
                            <asp:TextBox ID="txtCandidateRegistrationCandidateAddress" runat="server" Height="100px" Rows="5" TextMode="MultiLine" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>Post Code:</td><td>
                            <asp:TextBox ID="txtCandidateRegistrationCandidatePostCode" runat="server" Height="25px" Width="150px"></asp:TextBox></td></tr>
                        <tr><td>Date of Birth:</td><td>
                            <asp:TextBox ID="txtCandidateRegistrationCandidateBirthDate" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>Phone:</td><td>
                            <asp:TextBox ID="txtCandidateRegistrationCandidatePhone" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>E-mail:</td><td>
                            <asp:TextBox ID="txtCandidateRegistrationCandidateEmail" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>Username:</td><td>
                            <asp:TextBox ID="txtCandidateRegistrationCandidateUserName" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>Password:</td><td>
                            <asp:TextBox ID="txtCandidateRegistrationCandidatePassword" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>Confirm Password:</td><td>
                            <asp:TextBox ID="txtCandidateRegistrationCandidateConfirmPassword" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>Security Answer:</td><td>
                            <asp:TextBox ID="txtCandidateRegistrationCandidateSecurityAnswer" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>CV File:</td><td>
                            <asp:FileUpload ID="fileCandidateRegistrationCandidateCV" runat="server" Height="25px" Width="300px" /></td></tr>
                        <tr><td>Date:</td><td>
                            <asp:Label ID="lblCandidateRegistrationDateRegistered" runat="server" Height="25px" Width="300px"></asp:Label></td></tr>
                    </table>
            </div>
            <!-- END REGISTRATION FORM-->
                   <div class="RegistrationButtons">
                       <asp:Button ID="BtnSaveDetails" runat="server" Text="Save" OnClick="BtnSaveDetails_Click" Height="40px" Width="150px" />
                       <asp:Button ID="BtnClearForm" runat="server" Text="Clear" Height="40px" Width="150px" />
                    </div>
            <asp:Label ID="lblCandidateRegistrationValidationError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        </div>
        

    </section>
    <!--this section contains info. searcheable by search engines-->
 
    <!--footer contains loogo banner image and the links to other pages/ same as header but no image-->
    <footer>
        <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="CandidateRegistrationHomePageBotLink" runat="server" OnClick="RegistrationHomePageBotLink_Click"  >Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateRegistrationAboutUsBotLink" runat="server" OnClick="RegistrationAboutUsBotLink_Click" >About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateRegistrationRegistrationBotLink" runat="server" OnClick="RegistrationRegistrationBotLink_Click"  >Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateRegistrationJobSearchBotLink" runat="server" OnClick="RegistrationJobSearchBotLink_Click" >Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateRegistrationContactUsBotLink" runat="server" OnClick="RegistrationContactUsBotLink_Click" >Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateRegistrationLoginBotLink" runat="server" OnClick="RegistrationLoginBotLink_Click" >Login</asp:LinkButton></li>
            </ul>
        </nav>    

    </footer>
    <!--the section contains info. searcheable by search engines-->
    <section>
        <div>
            <p class="bottom">
                Janzeb Masiano the proprietor of InigmaIT &reg; Employment UK recruitment services provider Based at 48 Winifred Avenue, Earlsdon Coventry CV5 6JS
                <br />Inigma Employment © Copywrite  <% lblCandidateRegistrationYear.Text = Convert.ToString(DateTime.Today.Year); %><asp:Label ID="lblCandidateRegistrationYear" runat="server" Text="Label"></asp:Label>
            </p>

        </div>
    </section>
</form>
</body>
</html>
