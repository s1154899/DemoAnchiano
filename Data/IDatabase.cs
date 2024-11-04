using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAnchiano.Data
{
    public interface IDatabase
    {
        public AUser[] GetUsers(int id);
        public AUser[] GetUsers(int lowerRange, int higherRange);
        public AUser[] GetUsers();
        public AUser CreateUser(string name, int age, DateTime time_subcribed, bool isActive);
        public AUser UpdateUser(int id,string name, int age, DateTime time_subcribed, bool isActive);
        public AUser DeleteUser(int id);

        public AEmotion[] GetEmotionsByUserID(int userId);
        public AEmotion[] GetEmotionsByEmotionsID(int id);
        public AEmotion[] GetEmotions();
        public AEmotion CreateEmotion(int userID, string nameEmotion, int level, string color);
        public AEmotion UpdateEmotion(int id, int userID, DateTime Created, string nameEmotion, int level, string color);
        public AEmotion DeleteEmotion(int id);

    }
}
