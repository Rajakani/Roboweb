using Roboweb.Pages;
using System;
using System.Collections.Generic;

namespace Roboweb.App
{
    public class App
    {
        BrowserFactory factory { get; set; }
        RoboBrowser browser { get; set; }
        List<IPage> pages { get; set; }
        Options options;

        
        public App(Options options)
        {
            factory = new BrowserFactory(options);
            this.options = options;
            browser = factory.GetBrowser();
        }

        public RoboBrowser Start()
        {
            browser.browserSession.Visit("/");
            return browser ;
        }

    }
}
