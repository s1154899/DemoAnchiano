using DemoAnchiano.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DemoAnchiano.Controller.CommandImplementations
{
    class UpdateUserCommand : ICommand
    {
        public AUser UserToUpdate;
        public UpdateUserCommand(AUser userToUpdate)
        {
            UserToUpdate = userToUpdate;
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
                database.UpdateUser(UserToUpdate.ID, UserToUpdate.Name,UserToUpdate.Age, UserToUpdate.TimeSubscribed,UserToUpdate.IsActive);

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return "Gebruiker veranderd: " + UserToUpdate.ID+ UserToUpdate.Name+UserToUpdate.Age+ UserToUpdate.TimeSubscribed+UserToUpdate.IsActive;
        }
    }
}
