using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Media;

namespace DemoAnchiano.Data.DatabaseJsonImplementation
{
    public class JsonDatabase : IDatabase
    {
        private string _usersFile;
        private string _emotionFile;

        public JsonDatabase(string userFile, string emotionFile) {

            _usersFile = userFile;
            _emotionFile = emotionFile;
        }

        public AEmotion CreateEmotion( int userID,string emotionName ,int level, string color)
        {
            AEmotion[] OldData = GetEmotions();
            List<AEmotion> EmotionToCreateInJsonFile = new List<AEmotion>(OldData);
            EmotionToCreateInJsonFile.Add(new JsonEmotion(CreateEmotionID(), userID, emotionName, DateTime.Now, level, color));
            string jsonString = JsonSerializer.Serialize(EmotionToCreateInJsonFile.ToArray());
            FileWriter.WriteNewToFile(_emotionFile,jsonString);
            return EmotionToCreateInJsonFile.Last();
        }

       

        public AUser CreateUser(string name, int age, DateTime time_subcribed, bool isActive)
        {
            AUser[] OldData = GetUsers();
            List<AUser> UserToCreateInJsonFile = new List<AUser>(OldData);
            UserToCreateInJsonFile.Add(new JsonUser(CreateUserID(), name, age, time_subcribed, isActive));
            string jsonString = JsonSerializer.Serialize(UserToCreateInJsonFile.ToArray());
            FileWriter.WriteNewToFile(_usersFile, jsonString);
            return UserToCreateInJsonFile.Last();
        }

        public AEmotion DeleteEmotion(int id)
        {
            AEmotion emotionToDelete = GetEmotionsByEmotionsID(id)[0];
            string jsonString = JsonSerializer.Serialize((from emotions in GetEmotions() where emotions.ID != id select emotions).ToArray());
            FileWriter.WriteNewToFile(_emotionFile, jsonString);
            return emotionToDelete;

        }

        public AUser DeleteUser(int id)
        {
            AUser userToDelete = GetUsers(id)[0];
            string jsonString = JsonSerializer.Serialize((from user in GetUsers() where user.ID != id select user).ToArray());
            FileWriter.WriteNewToFile(_usersFile, jsonString);
            return userToDelete;
        }

      
        public AEmotion[] GetEmotionsByEmotionsID(int id)
        {
            return (from emotions in GetEmotions()
                    where emotions.ID == id
                    orderby emotions.TimeCreated
                    select emotions).ToArray();
        }

        public AEmotion[] GetEmotionsByUserID(int userId)
        {
            return (from emotions in GetEmotions()
                   where emotions.UserID == userId
                   orderby emotions.TimeCreated
                   select emotions).ToArray();
        }

        public AEmotion[] GetEmotions()
        {
            string? users = FileWriter.GetFile(_emotionFile);
            if (users == null || users == "")
            {
                return new AEmotion[0];
            }
            return JsonSerializer.Deserialize<AEmotion[]>(users);
        }

        public AUser[] GetUsers(int id)
        {
            return (from user in GetUsers()
                   where user.ID == id
                   select user).ToArray();
        }

        public AUser[] GetUsers(int lowerRange, int higherRange)
        {
            return GetUsers().Skip(lowerRange).Take(higherRange).ToArray();
        }

        public AUser[] GetUsers()
        {

            string? users = FileWriter.GetFile(_usersFile);
            if (users == null || users == "") { 
                return new AUser[0];
            }
            return JsonSerializer.Deserialize<AUser[]>(users);
        }

        public AEmotion UpdateEmotion(int id ,int userID, DateTime Created, string nameEmotion, int level, string color)
        {
            DeleteEmotion(id);
            return CreateEmotion(userID, nameEmotion, level, color);

        }

        public AUser UpdateUser(int id, string name, int age, DateTime time_subcribed, bool isActive)
        {
            DeleteUser(id);
            return CreateUser(name, age, time_subcribed, isActive);
        }

        private int CreateUserID() {

            List<int> ints = (from users in GetUsers() select users.ID).ToList();
            int newId = ints.Count;
            while (ints.Any(OtherID => newId == OtherID)) {
                newId++;
                
            }
            return newId;
        }
        private int CreateEmotionID()
        {

            List<int> ints = (from emotions in GetEmotions() select emotions.ID).ToList();
            int newId = ints.Count;
            while (ints.Any(OtherID => newId == OtherID))
            {
                newId++;

            }
            return newId;
        }

    }
}
