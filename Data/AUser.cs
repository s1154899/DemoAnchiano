using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAnchiano.Data
{
    public class AUser
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public DateTime TimeSubscribed { get; set; }
        public bool IsActive { get; set; }


        public AUser() {
        
        }
        public AUser(int id, string name, int age, DateTime time_subcribed, bool isActive)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.TimeSubscribed = time_subcribed;
            this.IsActive = isActive;

        }


    }
}
