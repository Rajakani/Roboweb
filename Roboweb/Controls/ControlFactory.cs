using Coypu;
using System;
using System.Collections.Generic;

namespace Roboweb.Controls
{
    public class ControlFactory
    {
        private Scope browser;
        public ControlFactory(RoboBrowser browser)
        {
            this.browser = browser.browserSession;
        }
        public ControlFactory(RoboBrowser browser, bool IsGrid)
        {
            this.browser = browser.SessionScope;
        }

        public T Create<T>(string Id)where T: IControl
        {
            T Control;
            switch (typeof(T).ToString().ToLower())
            {
                case "roboweb.controls.itextbox":
                    Control = (T)(ITextBox)new TextBox((BrowserSession)this.browser, Id);
                    break;
                case "roboweb.controls.ibutton":
                    Control = (T)(IButton)new Button((BrowserSession)this.browser, Id);
                    break;
                case "roboweb.controls.igrid":
                    Dictionary<string, object> prop = new Dictionary<string, object>();
                    Control = (T)(IGrid)new Grid((BrowserSession)this.browser, Id, prop);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return Control;
        }
      
    }
}
