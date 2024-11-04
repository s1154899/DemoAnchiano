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
    class UpdateEmotionCommand : ICommand
    {
        public AEmotion EmotionToUpdate;
        public UpdateEmotionCommand(AEmotion emotionToUpdate)
        {
            EmotionToUpdate = emotionToUpdate;
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
                database.UpdateEmotion(EmotionToUpdate.ID, EmotionToUpdate.UserID,EmotionToUpdate.TimeCreated, EmotionToUpdate.EmotionName, EmotionToUpdate.level,EmotionToUpdate.color);

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public override string ToString()
        {
            return "emoties veranderd: " + EmotionToUpdate.ID+ EmotionToUpdate.UserID+EmotionToUpdate.TimeCreated+ EmotionToUpdate.EmotionName+ EmotionToUpdate.level+EmotionToUpdate.color;
        }
    }
}
