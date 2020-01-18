<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectLogin.aspx.cs" Inherits="InigmaIT.HTML.SelectLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="../CSS/MainStyleSheet.css" />
    <link rel="stylesheet" href="../CSS/SelectLoginPage.css" />
    <title>Choose Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <!--header contains loogo banner image and the links to other pages-->
    <header>
        <div class="SlimLogoHeaderImage"></div> <!--  <img src="../IMAGE/SlimLogoHeader.jpg" /> -->
        <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="SelectLoginHomePageTopLink" runat="server" OnClick="SelectLoginHomePageTopLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="SelectLoginAboutUsTopLink" runat="server" OnClick="SelectLoginAboutUsTopLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="SelectLoginRegistrationTopLink" runat="server" OnClick="SelectLoginRegistrationTopLink_Click">Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="SelectLoginJobSearchTopLink" runat="server" OnClick="SelectLoginJobSearchTopLink_Click">Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="SelectLoginContactUsTopLink" runat="server" OnClick="SelectLoginContactUsTopLink_Click">Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="SelectLoginLoginTopLink" runat="server" OnClick="SelectLoginLoginTopLink_Click">Login</asp:LinkButton></li>
            </ul>
        </nav>
    </header>
    <!--this section contains the main image-->
    <section class="CentredSpace">

        <div class="SlectLoginForm">
            <h1>Select Login</h1>

            <div class="SlectLoginFormButtons">
                <asp:Button ID="btnSelectLoginCandidateLogin" runat="server" Text="Candidate" OnClick="btnSelectLoginCandidateLogin_Click" />
                <asp:Button ID="btnSelectLoginEmployerLogin" runat="server" Text="Employer" OnClick="btnSelectLoginEmployerLogin_Click" />
                <asp:Button ID="btnSelectLoginStaffLogin" runat="server" Text="Staff" OnClick="btnSelectLoginStaffLogin_Click" />
            </div>
        </div>


    </section>
    <!--this section contains info. searcheable by search engines-->
    <!--footer contains loogo banner image and the links to other pages/ same as header but no image-->
    <footer>
        <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="SelectLoginHomePageBotLink" runat="server" OnClick="SelectLoginHomePageBotLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="SelectLoginAboutUsBotLink" runat="server" OnClick="SelectLoginAboutUsBotLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="SelectLoginRegistrationBotLink" runat="server" OnClick="SelectLoginRegistrationBotLink_Click">Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="SelectLoginJobSearchBotLink" runat="server" OnClick="SelectLoginJobSearchBotLink_Click">Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="SelectLoginContactUsBotLink" runat="server" OnClick="SelectLoginContactUsBotLink_Click">Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="SelectLoginLoginBotLink" runat="server" OnClick="SelectLoginLoginBotLink_Click">Login</asp:LinkButton></li>
            </ul>
        </nav>
    </footer>
    <!--the section contains info. searcheable by search engines-->
    <section>
        <div>
            <p class="bottom">
                Janzeb Masiano the proprietor of InigmaIT &reg; Employment UK recruitment services provider Based at 48 Winifred Avenue, Earlsdon Coventry CV5 6JS
                <br />Inigma Employment © Copywrite <% lblSelectLoginYear.Text = Convert.ToString(DateTime.Today.Year); %><asp:Label ID="lblSelectLoginYear" runat="server" Text="Label"></asp:Label>
            </p>

        </div>
    </section>
    </form>
</body>
</html>
