using CommandSystem;
using PluginAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ICommand = CommandSystem.ICommand;

namespace TpsCommand
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class RegenerateMap : ICommand
    {
        public string Command => "Tps";

        public string[] Aliases { get; } = { "tps" };

        public string Description => "";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = $"Current TPS: {Server.TPS}";
            return true;
        }
    }
}
