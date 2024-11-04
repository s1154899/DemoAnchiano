using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAnchiano.Data.DatabaseJsonImplementation
{
    internal class JsonEmotion : AEmotion
    {
        public JsonEmotion(int id ,int userID, string emotionName, DateTime timeCreated, int level, string color) : base( id, userID, emotionName, timeCreated, level, color)
        {
        }
    }
}
