using DemoAnchiano.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAnchiano.Controller.CommandImplementations
{
    class CreateEmotionCommand : ICommand
    {
        public AEmotion EmotionToCreate;
        public CreateEmotionCommand(AEmotion emotionToCreate)
        {
            EmotionToCreate = emotionToCreate;
            CommandController.AddCommand(this);
        }
        public CreateEmotionCommand( int UserID,string emotionName, int level, string color) : this(new AEmotion(0,UserID, emotionName, DateTime.MinValue, level, color))
        {
          
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
                database.CreateEmotion(EmotionToCreate.UserID, EmotionToCreate.EmotionName, EmotionToCreate.level, EmotionToCreate.color);

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return "Emotie aangemaakt: "+EmotionToCreate.UserID + EmotionToCreate.EmotionName+ EmotionToCreate.level+ EmotionToCreate.color;
        }
    }
}
