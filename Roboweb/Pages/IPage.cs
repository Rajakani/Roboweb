using Roboweb.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roboweb.Pages
{
    public interface IPage
    {
        string Name { get; set; }
        bool IsPageLoaded(string identifier);
        List<IControl> Controls { get; set; }
    }
}
