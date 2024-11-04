using DemoAnchiano.Data;
using DemoAnchiano.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DemoAnchiano.Controller.CommandImplementations
{
    class ReadUserCommand : ICommand
    {
        public ListView ListView;
        public ReadUserCommand(ListView listView) {
            ListView = listView;
            CommandController.AddCommand(this);
        }
        public bool execute()
        {
            
            return execute(new string[0]);
        }

        public bool execute(string[] parameters)
        {
            IDatabase database = CommandController.GetDatabase();
            try
            {
                switch (parameters.Length) {
                    case 1:
                        ListView.ItemsSource = database.GetUsers(Int32.Parse(parameters[0]));
                        break;
                     case 2:
                        ListView.ItemsSource = database.GetUsers(Int32.Parse(parameters[0]), Int32.Parse(parameters[1]));
                        break;
                     default:
                        ListView.ItemsSource = database.GetUsers();
                        break;

                }
               
            }
            catch (Exception ex) { 
            return false;
            }
            return true;
        }

        public override string ToString()
        {
            return "Gebruikers gelezen";
        }
    }
}
