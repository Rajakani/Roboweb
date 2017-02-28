using Coypu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roboweb.Controls
{
    public interface IControl
    {
        BrowserSession Browser { get; set; }
    }
}
