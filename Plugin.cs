using PluginAPI.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpsCommand
{
    public class Plugin
    {
        [PluginEntryPoint("TPS Command", "1.0.0", "Shows the current TPS", "GBN")]
        public void EntryPoint()
        {
            // Nothing ??
        }
    }
}
