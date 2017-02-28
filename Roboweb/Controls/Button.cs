using Coypu;
using System;


namespace Roboweb.Controls
{
    public class Button : Control<IButton>, IButton
    {
        public Button(BrowserSession browser, string Id) : base(browser, Id)
        {
        }

    }
}
