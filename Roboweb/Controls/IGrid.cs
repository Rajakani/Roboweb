using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roboweb.Controls
{
    public interface IGrid: IControl
    {
        void AddControl<T>(string Id) where T : IControl;
    }
}
