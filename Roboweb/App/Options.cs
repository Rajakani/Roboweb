using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roboweb.App
{
    public class Options
    {
        public BrowserType BrowserType { get; set; }
        public string Apphost { get; set; }
        public bool SSL { get; set; } = false;
    }

    public enum BrowserType
    {
        Chrome,
        FireFox,
        IE,
        PhantomJS
    }
}
