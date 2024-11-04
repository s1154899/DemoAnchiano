using DemoAnchiano.Data;
using DemoAnchiano.Data.DatabaseJsonImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAnchiano.Controller
{

    public class CommandController
    {
        private static Queue<ICommand> _commands = new Queue<ICommand>();
        private static IDatabase _database = new JsonDatabase("userfile.json", "emotionfile.json");
        public static IDatabase GetDatabase() { return _database; }
        public static void AddCommand(ICommand command)
        {
            _commands.Enqueue(command);
        }

        public static string GetPastCommands()
        {
            string commandsAsString = "";
            while (_commands.Count > 0)
            {
                ICommand command = _commands.Dequeue();
                commandsAsString += command.ToString() + "\n";
            }
            return commandsAsString;
        }
    }
}
