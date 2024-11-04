using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAnchiano.Controller
{
    public interface ICommand
    {
        public bool execute();
        public bool execute(string[] parameters);


    }
}
