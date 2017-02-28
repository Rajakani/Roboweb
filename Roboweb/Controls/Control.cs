using Coypu;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Roboweb.Controls
{
    public class Control<T>: DynamicObject, IControl
    {
        private Scope browser;
        private Lazy<ElementScope> element;
        private readonly Dictionary<string, object> _properties;
        public string Id { get; set; }
        protected ControlFactory controlFactory;
        public Control(BrowserSession browser, string Id)
        {
            this.Id = Id;
            this.browser = browser;
            element = new Lazy<ElementScope>(() => browser.FindId(Id));
        }
        public Control(BrowserSession browser, string Id, Dictionary<string, object> properties)
        {
            this.Id = Id;
            this.browser = browser;
            _properties = properties;
            RoboBrowser rbrowser = new RoboBrowser(browser.FindId(Id));
            controlFactory = new ControlFactory(rbrowser, true);
        }

        public Control(Scope browser, string Id)
        {
            this.Id = Id;
            this.browser = browser;
            RoboBrowser rbrowser = new RoboBrowser(browser.FindId(Id));
            controlFactory = new ControlFactory(rbrowser, true);
            element = new Lazy<ElementScope>(() => browser.FindId(Id));
        }

        public BrowserSession Browser
        {
            get{ return (BrowserSession)browser;}
            set{browser = value;}
        }
        
        public Scope GetElement()
        {
            return browser.FindId(Id);
        }
               

        public bool Click()
        {
            bool result = false;
            try
            {              
                element.Value.Click();
                result = true;
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public bool Type(string value)
        {
            bool result = false;
            try
            {               
                element.Value.FillInWith(value);
                result = true;               
            }
            catch (Exception)
            {
                throw;
            }
            return result;
           
        }

        public string Value()
        {
            return element.Value.Text;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (_properties.ContainsKey(binder.Name))
            {
                result = _properties[binder.Name];
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            if (_properties.ContainsKey(binder.Name))
            {
                _properties[binder.Name] = value;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
