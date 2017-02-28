using Coypu.Drivers;
using Coypu.Drivers.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roboweb.App
{
    public class ChromeProfile : SeleniumWebDriver
    {
        public ChromeProfile(Browser browser)
            : base(CustomProfile(), browser)
        {
        }

        private static RemoteWebDriver CustomProfile()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("test-type");
            chromeOptions.AddArguments("start-maximized");
            chromeOptions.AddArguments("--disable-extensions");
            chromeOptions.AddArguments("no-sandbox");

            return new ChromeDriver(chromeOptions);
        }
    }
}
