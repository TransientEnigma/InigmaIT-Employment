<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="InigmaIT.HTML.AboutUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="stylesheet" href="../CSS/MainStyleSheet.css" />
         <link rel="stylesheet" href="../CSS/AboutUsPage.css" />
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
                    <asp:LinkButton ID="AboutUsHomePageTopLink" runat="server" OnClick="AboutUsHomePageTopLink_Click" >Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="AboutUsAboutUsTopLink" runat="server" OnClick="AboutUsAboutUsTopLink_Click"  >About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="AboutUsRegistrationTopLink" runat="server" OnClick="AboutUsRegistrationTopLink_Click" >Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="AboutUsJobSearchTopLink" runat="server" OnClick="AboutUsJobSearchTopLink_Click" >Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="AboutUsContactUsTopLink" runat="server" OnClick="AboutUsContactUsTopLink_Click"  >Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="AboutUsLoginTopLink" runat="server" OnClick="AboutUsLoginTopLink_Click" >Login</asp:LinkButton></li>
            </ul>
        </nav>
    </header>
    <div class="CentredContents">
        <!--this section contains the left side image and information-->
        <section class="InsideLeft">
            <div class="InsideTopLeft">
                <img src="../IMAGE/Ladyx.png" width="230"/>
                <p>
                    <strong>Our Aims</strong>
                    <br />
                    
                        Inigma Employment is the new fastest growing recruitment player in the UK national recruitment market. We aim to provide an excellent customer service package to clients, and complete satisfaction with our unique method of selection of employees, by using our practical knowledge and understanding of various worksector requirements to
                        identify key skills and expertise in prospective employees and successfully screen them for the right job. Inigma Employment aims to maintain and uphold the highest standard of customer service to all our clients, and to work closely with them, making every attempt to find the highest calibre of employee with the right skill base and work etiquette, to meet the job specification.
                    
                </p>
            </div>
            <div></div>
            <div class="InsideBottomLeft">
                <img src="../IMAGE/Team.png" width="230"/>
                <p>
                    <strong>Achieving Our Aims</strong>
                    <br />We have an experienced team of staff from different skilled backgrounds; each having knowledge and understanding of a particular field we can look to assess. For example areas such as
                    administration, e-commerce, service sectors, IT, Sales, Engineering etc. Each candidate will be screened by a member of staff with an understanding of the relevant area before being forwarded to the employer. We also have methods to test prospective employees by way of written or practical test.

                </p>
            </div>
        </section>
        <!--this section contains the right side image and information-->
        <section class="InsideRight">
            <div class="ChartImage">
                <p>
                    <strong>Working to Benefit You</strong>
                    <br />
                    As well as the benefit accrued by the employee in satisfaction in work, a proper screening program can yield positive employees with greater moral and better productivity. The right employee can help to cut cost by working more efficiently and effectively. Our continued attitude in seeking and providing the best employees is done with the intention of developing positive relationships with our clients, and so making us the number one choice for almost any recruitment solution and thus securing our continued success as the fastest growing recruitment agency.
                </p>
                <img src="../IMAGE/Chart.png" />
            </div>
        </section>
    </div>
   
    <!--footer contains loogo banner image and the links to other pages/ same as header but no image-->
    <footer>
         <nav>
            <ul>
                <li>
                    <asp:LinkButton ID="AboutUsHomePageBotLink" runat="server" OnClick="AboutUsHomePageBotLink_Click"  >Home</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="AboutUsAboutUsBotLink" runat="server" OnClick="AboutUsAboutUsBotLink_Click"  >About Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="AboutUsRegistrationBotLink" runat="server" OnClick="AboutUsRegistrationBotLink_Click"  >Registration</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="AboutUsJobSearchBotLink" runat="server" OnClick="AboutUsJobSearchBotLink_Click"  >Job Search</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="AboutUsContactUsBotLink" runat="server" OnClick="AboutUsContactUsBotLink_Click" >Contact Us</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="AboutUsLoginBotLink" runat="server" OnClick="AboutUsLoginBotLink_Click" >Login</asp:LinkButton></li>
            </ul>
        </nav>
    </footer>
    <!--the section contains info. searcheable by search engines-->
    <section>
        <div>
            <p class="bottom">
                Janzeb Masiano the proprietor of InigmaIT &reg; Employment UK recruitment services provider Based at 48 Winifred Avenue, Earlsdon Coventry CV5 6JS
                <br />Inigma Employment © Copywrite <% lblAboutUsthisYear.Text = Convert.ToString(DateTime.Today.Year); %><asp:Label ID="lblAboutUsthisYear" runat="server" Text="Label"></asp:Label>
            </p>

        </div>
    </section>
    </form>
</body>
</html>
