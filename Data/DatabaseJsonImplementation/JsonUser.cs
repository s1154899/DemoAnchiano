using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAnchiano.Data.DatabaseJsonImplementation
{
    public class JsonUser : AUser
    {
        public JsonUser(int id, string name, int age, DateTime time_subcribed, bool isActive) : base(id, name, age, time_subcribed, isActive)
        {
        }
    }
}
