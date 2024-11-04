using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAnchiano.Data.DatabaseJsonImplementation
{
    static public class FileWriter
    {
        static FileWriter() { 
        
        
        
        }

        public static bool AddToFile(string fileName, string StringToAdd) {
            File.AppendAllText(fileName, StringToAdd);
            return true;
        }

        public static string GetFile(string fileName) {
            if (!File.Exists(fileName)) {
                return "";
            }
            return File.ReadAllText(fileName);
        }

        public static bool WriteNewToFile(string fileName, string stringToWrite) {
            
            File.WriteAllText(fileName, stringToWrite);
            return true;
        
        }

        public static void DeleteFile(string fileName) {

            File.Delete(fileName);
        }

    }
}
