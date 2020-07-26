using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TestExercise
{
    public class LoginOrRegister
    {
        public IWebElement nekiElement => Driver.driver.FindElement(By.CssSelector());
    }
}
