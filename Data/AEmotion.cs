using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DemoAnchiano.Data
{
    public class AEmotion
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string? EmotionName { get; set; }
        public int level { get; set; }
        public string? color { get; set; }

        public DateTime TimeCreated { get; set; }


        public AEmotion() { }
        public AEmotion(int id, int userID, string emotionName, DateTime timeCreated, int level, string color)
        {
            this.ID = id;
            this.UserID = userID;
            this.EmotionName = emotionName;
            this.TimeCreated = timeCreated;
            this.level = level;
            this.color = color;

        }
    }
}
