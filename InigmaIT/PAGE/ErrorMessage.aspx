<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorMessage.aspx.cs" Inherits="InigmaIT.HTML.ErrorMessage" %>

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
                    <asp:LinkButton ID="ErrorMessageHomePageTopLink" runat="server" OnClick="ErrorMessageHomePageTopLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ErrorMessageAboutUsTopLink" runat="server" OnClick="ErrorMessageAboutUsTopLink_Click" >About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ErrorMessageRegistrationTopLink" runat="server" OnClick="ErrorMessageRegistrationTopLink_Click">Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ErrorMessageJobSearchTopLink" runat="server" OnClick="ErrorMessageJobSearchTopLink_Click" >Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ErrorMessageContactUsTopLink" runat="server" OnClick="ErrorMessageContactUsTopLink_Click" >Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ErrorMessageLoginTopLink" runat="server" OnClick="ErrorMessageLoginTopLink_Click" >Login</asp:LinkButton></li>
            </ul>
        </nav>
    </header>
    <!--this section contains the main image-->
    <section class="CentredSpace">

        <div class ="JobApplicationsForm">
            <h1>ERROR! <br />The requested action could not be performed</h1>

                         <div class="JobApplicationsButtons">
                             <asp:Button ID="btnErrorMessageOK" runat="server" Text="Button" OnClick="btnErrorMessageOK_Click" Height="40px" Width="100px" />

                    </div>
        </div>
        

    </section>
    <!--this section contains info. searcheable by search engines-->
 
    <!--footer contains loogo banner image and the links to other pages/ same as header but no image-->
    <footer>
        <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="ErrorMessageHomePageBotLink" runat="server" OnClick="ErrorMessageHomePageBotLink_Click" >Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ErrorMessageAboutUsBotLink" runat="server" OnClick="ErrorMessageAboutUsBotLink_Click" >About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ErrorMessageRegistrationBotLink" runat="server" OnClick="ErrorMessageRegistrationBotLink_Click" >Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ErrorMessageJobSearchBotLink" runat="server" OnClick="ErrorMessageJobSearchBotLink_Click" >Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ErrorMessageContactUsBotLink" runat="server" OnClick="ErrorMessageContactUsBotLink_Click" >Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ErrorMessageLoginBotLink" runat="server" OnClick="ErrorMessageLoginBotLink_Click">Login</asp:LinkButton></li>
            </ul>
        </nav>
    </footer>
    <!--the section contains info. searcheable by search engines-->
    <section>
        <div>
            <p class="bottom">
                Janzeb Masiano the proprietor of InigmaIT &reg; Employment UK recruitment services provider Based at 48 Winifred Avenue, Earlsdon Coventry CV5 6JS
                <br />Inigma Employment © Copywrite <% lblErrorMessageYear.Text = Convert.ToString(DateTime.Today.Year); %><asp:Label ID="lblErrorMessageYear" runat="server" Text="Label"></asp:Label>
            </p>

        </div>
    </section>
    </form>
</body>
</html>
