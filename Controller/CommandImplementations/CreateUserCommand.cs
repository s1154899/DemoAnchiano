using DemoAnchiano.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAnchiano.Controller.CommandImplementations
{
    class CreateUserCommand : ICommand
    {
        public AUser UserToCreate;
        public CreateUserCommand(AUser userToCreate)
        {
            UserToCreate = userToCreate;
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
                database.CreateUser(UserToCreate.Name, UserToCreate.Age, UserToCreate.TimeSubscribed, UserToCreate.IsActive);

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public override string ToString()
        {
            return "Gebruiker aangemaakt: " + UserToCreate.Name+ UserToCreate.Age+ UserToCreate.TimeSubscribed+ UserToCreate.IsActive;
        }
    }
}
