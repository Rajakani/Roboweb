using Coypu;
using Coypu.Drivers;

namespace Roboweb.App
{
    public class BrowserFactory
    {
        private Options options;
        
        public BrowserFactory(Options options)
        {
            this.options = options;            
        }

        public RoboBrowser GetBrowser()
        {
            RoboBrowser browser = new RoboBrowser();
            SessionConfiguration config = new SessionConfiguration();
            config.AppHost = options.Apphost;
            config.SSL = options.SSL;

            if (options.BrowserType == BrowserType.Chrome)
            {
                config.Browser = Browser.Chrome;
                config.Driver = typeof(ChromeProfile);                
            }

            browser.browserSession = new BrowserSession(config);
            return browser;
        }
    }
}
