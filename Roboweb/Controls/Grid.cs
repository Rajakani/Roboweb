using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coypu;

namespace Roboweb.Controls
{
    public class Grid : Control<IGrid>, IGrid
    {
        public dynamic Controls;


        public Grid(BrowserSession browser, string Id) : base(browser, Id)
        {
             Controls = new Control<IControl>(browser, Id);

        }
        public Grid(BrowserSession browser, string Id, Dictionary<string, object> properties) : base(browser, Id, properties)
        {
            Controls = new Control<IControl>(browser, Id);            

        }
        public void AddControl<T>(string Id)where T: IControl
        {
            Controls[Id] = (T)controlFactory.Create<T>(Id);
        }
       

    }
}
