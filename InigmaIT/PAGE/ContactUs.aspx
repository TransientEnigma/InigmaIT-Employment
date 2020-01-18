<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="InigmaIT.HTML.ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="stylesheet" href="../CSS/MainStyleSheet.css" />
         <link rel="stylesheet" href="../CSS/ContactUsPage.css" />
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
                    <asp:LinkButton ID="ContactUsHomePageTopLink" runat="server" OnClick="ContactUsHomePageTopLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ContactUsAboutUsTopLink" runat="server" OnClick="ContactUsAboutUsTopLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ContactUsRegistrationTopLink" runat="server" OnClick="ContactUsRegistrationTopLink_Click">Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ContactUsJobSearchTopLink" runat="server" OnClick="ContactUsJobSearchTopLink_Click">Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ContactUsContactUsTopLink" runat="server" OnClick="ContactUsContactUsTopLink_Click">Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ContactUsLoginTopLink" runat="server" OnClick="ContactUsLoginTopLink_Click">Login</asp:LinkButton></li>
            </ul>
        </nav>
    </header>
    <!--this section contains the main image-->
    <section>
        <div class="BuildingImage">
            <div class="ContactInfo">
                <div>
                    <p>
                        &nbsp; &nbsp;<u>ADDRESS</u>
                        <br />InigmaIT Employment
                        <br />Winifred Avenue
                        <br />Earlson
                        <br />Coventry
                        <br />CV5 6JS
                        <br />
                        <br />&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<u>MAP</u>
                        <br />>>&nbsp; <a href="https://www.google.com/maps/place/Winifred+Ave,+Coventry/@52.4021209,-1.527286,17z/data=!3m1!4b1!4m5!3m4!1s0x48774b0782ef6187:0xbb4244516c3541a5!8m2!3d52.4021209!4d-1.5250973">Click Here</a> &nbsp; <<
                    </p>
                </div>
                <div>
                    <p>
                        &nbsp; &nbsp;<u>OPENING HOURS</u>
                        <br />Monday &nbsp;&nbsp;&nbsp;9AM - 5PM
                        <br />Tuesday &nbsp;&nbsp;9AM - 5PM
                        <br />Wedday &nbsp;&nbsp;&nbsp;9AM - 5PM
                        <br />Thursday &nbsp;9AM - 5PM
                        <br />Friday &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;9AM - 5PM
                        <br />Saturday &nbsp; CLOSED
                        <br />Sunday &nbsp;&nbsp;&nbsp; CLOSED
                    </p>
                </div>
                <div>
                    <p>
                        &nbsp; &nbsp;<u>RECRUITMENT</u>
                        <br />P: +44 (0) 7816152348
                        <br />E: janzebmasiano@yahoo.com
                        <br />
                        <br />
                        &nbsp; &nbsp;<u>ENQUIRIES</u>
                        <br />P: +44 (0) 7816152348
                        <br />E: janzebmasiano@yahoo.com

                    </p>
                </div>
            </div>
        </div>
    </section>


    <!--footer contains loogo banner image and the links to other pages/ same as header but no image-->
    <footer>
        <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="ContactUsHomePageBotLink" runat="server" OnClick="ContactUsHomePageBotLink_Click">Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ContactUsAboutUsBotLink" runat="server" OnClick="ContactUsAboutUsBotLink_Click">About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ContactUsRegistrationBotLink" runat="server" OnClick="ContactUsRegistrationBotLink_Click">Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ContactUsJobSearchBotLink" runat="server" OnClick="ContactUsJobSearchBotLink_Click">Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ContactUsContactUsBotLink" runat="server" OnClick="ContactUsContactUsBotLink_Click">Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="ContactUsLoginBotLink" runat="server" OnClick="ContactUsLoginBotLink_Click">Login</asp:LinkButton></li>
            </ul>
        </nav>
    </footer>
    <!--the section contains info. searcheable by search engines-->
    <section>
        <div>
            <p class="bottom">
                Janzeb Masiano the proprietor of InigmaIT &reg; Employment UK recruitment services provider Based at 48 Winifred Avenue, Earlsdon Coventry CV5 6JS
                <br />Inigma Employment © Copywrite <% lblContactUsYear.Text = Convert.ToString(DateTime.Today.Year); %><asp:Label ID="lblContactUsYear" runat="server" Text="Label"></asp:Label>
            </p>

        </div>
    </section>
    </form>
</body>
</html>
