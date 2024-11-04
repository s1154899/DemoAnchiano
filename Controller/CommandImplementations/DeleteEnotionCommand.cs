using DemoAnchiano.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAnchiano.Controller.CommandImplementations
{
    class DeleteEmotionCommand : ICommand
    {
        public AEmotion EmotionToDelete;
        public DeleteEmotionCommand(AEmotion emotionToDelete)
        {
            EmotionToDelete = emotionToDelete;
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
                database.DeleteEmotion(EmotionToDelete.ID);

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return "Emotie Verwijderd: " + EmotionToDelete.ID;
        }
    }
}
