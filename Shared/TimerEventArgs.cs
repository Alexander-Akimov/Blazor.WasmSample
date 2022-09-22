using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.WasmSample.Shared;

public class TimerEventArgs : EventArgs
{
    public DateTime SignalTime { get; set; }
}
