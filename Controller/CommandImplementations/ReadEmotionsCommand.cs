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
    class ReadEmotionsCommand : ICommand
    {
        public ListView ListView;
        public AUser UsersEmotions;
        public ReadEmotionsCommand(ListView listView,AUser usersEmotions)
        {
            ListView = listView;
            UsersEmotions = usersEmotions;
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
                ListView.ItemsSource = database.GetEmotionsByUserID(UsersEmotions.ID);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public override string ToString()
        {
            return "Gebruikers emoties gelezen: " + UsersEmotions.ID;
        }

    }
}
