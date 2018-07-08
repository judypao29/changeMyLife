using NUnit.Framework;
using HtmlAgilityPack;

namespace ChangeMyLife.Tests.formTests
{
    public class LoginFormTests
    {
        HtmlDocument loginForm;

        [OneTimeSetUp]
        public void Setup()
        {
            loginForm = new HtmlDocument();
            loginForm.Load("../../../../ChangeMyLife/Views/loginForm.cshtml");            
        }

        [Test]
        public void testLoginFormLoadsWithCorrectTextboxesAndLabels()
        {
            HtmlNode bodyNode = loginForm.DocumentNode.SelectSingleNode("body");
            HtmlNode formNode = bodyNode.SelectSingleNode("form");
            HtmlNode userNameDivNode = bodyNode.SelectNodes("div")[0];
            HtmlNode passwordDivNode = bodyNode.SelectNodes("div")[1];

            Assert.IsNotNull(bodyNode);
            Assert.IsNotNull(formNode);
            Assert.IsNotNull(userNameDivNode);
            Assert.IsNotNull(passwordDivNode);
        }
    }
}