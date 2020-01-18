<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CandidateLogin.aspx.cs" Inherits="InigmaIT.PAGE.CandidateLogin" %>

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
                    <asp:LinkButton ID="CandidateLoginHomePageTopLink" runat="server" OnClick="CandidateLoginHomePageTopLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateLoginAboutUsTopLink" runat="server" OnClick="CandidateLoginAboutUsTopLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateLoginRegistrationTopLink" runat="server" OnClick="CandidateLoginRegistrationTopLink_Click">Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateLoginJobSearchTopLink" runat="server" OnClick="CandidateLoginJobSearchTopLink_Click">Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateLoginContactUsTopLink" runat="server" OnClick="CandidateLoginContactUsTopLink_Click">Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateLoginLoginTopLink" runat="server" OnClick="CandidateLoginLoginTopLink_Click" >Login</asp:LinkButton></li>
            </ul>
        </nav>
    </header>
    <!--this section contains the main image-->
    <section class="CentredSpace">

        <div class ="RegistrationForm">
            <h1>Candidate Details</h1>
            <!-- START LOGIN FORM-->
            <div class="RegistrationTable">
                    <table border="0">
                        <tr><td>Username:</td><td>
                            <asp:TextBox ID="txtCandidateLoginUsername" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                        <tr><td>Password:</td><td>
                            <asp:TextBox ID="txtCandidateLoginPassword" runat="server" Height="25px" Width="300px"></asp:TextBox></td></tr>
                    </table>
            </div>
            <!-- END LOGIN FORM-->
                   <div class="RegistrationButtons">
                       <asp:Button ID="btnCandidateLoginLogin" runat="server" Text="Login" OnClick="btnCandidateLoginLogin_Click" Height="40px" Width="100px" />
                       <asp:Button ID="btnCandidateLoginCancel" runat="server" Text="Cancel" OnClick="btnCandidateLoginCancel_Click" Height="40px" Width="100px" />
                    </div>
        </div>
        

    </section>
    <!--this section contains info. searcheable by search engines-->
 
    <!--footer contains loogo banner image and the links to other pages/ same as header but no image-->
    <footer>
        <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="CandidateLoginHomePageBotLink" runat="server" OnClick="CandidateLoginHomePageBotLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateLoginAboutUsBotLink" runat="server" OnClick="CandidateLoginAboutUsBotLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateLoginRegistrationBotLink" runat="server" OnClick="CandidateLoginRegistrationBotLink_Click">Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateLoginJobSearchBotLink" runat="server" OnClick="CandidateLoginJobSearchBotLink_Click">Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateLoginContactUsBotLink" runat="server" OnClick="CandidateLoginContactUsBotLink_Click">Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="CandidateLoginLoginBotLink" runat="server" OnClick="CandidateLoginLoginBotLink_Click">Login</asp:LinkButton></li>
            </ul>
        </nav>
    </footer>
    <!--the section contains info. searcheable by search engines-->
    <section>
        <div>
            <p class="bottom">
                Janzeb Masiano the proprietor of InigmaIT &reg; Employment UK recruitment services provider Based at 48 Winifred Avenue, Earlsdon Coventry CV5 6JS
                <br />Inigma Employment © Copywrite <% lblCandidateLoginYear.Text = Convert.ToString(DateTime.Today.Year); %><asp:Label ID="lblCandidateLoginYear" runat="server" Text="Label"></asp:Label>
            </p>

        </div>
    </section>
    </form>
</body>
</html>
