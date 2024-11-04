using DemoAnchiano.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAnchiano.Controller.CommandImplementations
{
    class DeleteUserCommand : ICommand
    {
        public AUser UserToDelete;
        public DeleteUserCommand(AUser userToDelete)
        {
            UserToDelete = userToDelete;
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
                database.DeleteUser(UserToDelete.ID);

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return "Gebruiker Verwijderd: " + UserToDelete.ID;
        }
    }
}
