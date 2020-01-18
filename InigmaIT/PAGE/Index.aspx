<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="InigmaIT.HTML.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="../CSS/MainStyleSheet.css" />
    <title>InigmaIT Employment</title>
</head>
<body>
    <form id="form1" runat="server">
         <!--header contains loogo banner image and the links to other pages-->
    <header>
        <div class="SlimLogoHeaderImage"></div> <!--  <img src="../IMAGE/SlimLogoHeader.jpg" /> -->
        <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="IndexHomePageTopLink" runat="server" OnClick="IndexHomePageTopLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="IndexAboutUsTopLink" runat="server" OnClick="IndexAboutUsTopLink_Click" >About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="IndexRegistrationTopLink" runat="server" OnClick="IndexRegistrationTopLink_Click" >Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="IndexJobSearchTopLink" runat="server" OnClick="IndexJobSearchTopLink_Click" >Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="IndexContactUsTopLink" runat="server" OnClick="IndexContactUsTopLink_Click" >Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="IndexLoginTopLink" runat="server" OnClick="IndexLoginTopLink_Click" >Login</asp:LinkButton></li>
            </ul>
        </nav>
    </header>
    <!--this section contains the main image-->
    <section class="CentredContents">
        <div class="FrontpageImage">
            
        </div>
    </section>
    <!--this section contains info. searcheable by search engines-->
    <section>
        <p class="middle">
            Welcome to the fastest growing recruitment agency in the UK, with an array of knowledge and expertise in major recruitment areas, we can offer you more than just a recruitment solution for your recruitment needs.
        </p>
    </section>
    <!--footer contains loogo banner image and the links to other pages/ same as header but no image-->
    <footer>
        <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="IndexHomePageBotLink" runat="server" OnClick="IndexHomePageBotLink_Click" >Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="IndexAboutUsBotLink" runat="server" OnClick="IndexAboutUsBotLink_Click" >About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="IndexRegistrationBotLink" runat="server" OnClick="IndexRegistrationBotLink_Click" >Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="IndexJobSearchBotLink" runat="server" OnClick="IndexJobSearchBotLink_Click" >Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="IndexContactUsBotLink" runat="server" OnClick="IndexContactUsBotLink_Click" >Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="IndexLoginBotLink" runat="server" OnClick="IndexLoginBotLink_Click" >Login</asp:LinkButton></li>
            </ul>
        </nav>
    </footer>
    <!--the section contains info. searcheable by search engines-->
    <section>
        <div>
            <p class="bottom">
                Janzeb Masiano the proprietor of InigmaIT &reg; Employment UK recruitment services provider Based at 48 Winifred Avenue, Earlsdon Coventry CV5 6JS
                <br />Inigma Employment © Copywrite <% lblIndexYear.Text = Convert.ToString(DateTime.Today.Year); %><asp:Label ID="lblIndexYear" runat="server" Text="Label"></asp:Label>
            </p>
        </div>
    </section>
    </form>
</body>
</html>
