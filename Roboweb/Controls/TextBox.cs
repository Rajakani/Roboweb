using Coypu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roboweb.Controls
{
    public class TextBox : Control<ITextBox>, ITextBox
    {
        public TextBox(BrowserSession browser, string Id): base(browser, Id)
        {

        }
      
    }
}
