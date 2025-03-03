using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCShared.DotNetHelpers
{
    public class ResizeHelper
    {
        public Action<int,int> Action { get; set; }

        public ResizeHelper(Action<int, int> _action)
        {
            Action = _action;
        }

        [JSInvokable]
        public void ResizeCaller(int width, int height)
        {
            Action.Invoke(width, height);
        }
    }
}
