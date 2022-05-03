using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using BasePlugin.Interfaces;
using BasePlugin.Records;



namespace CountTheWords
{
   
    public class WriteTofilePlugin : IPlugin
    {

        public static string _Id = "count-words";
        public string Id => _Id;


        public  PluginOutput  Execute (PluginInput input)
        {
                Console.WriteLine("הכנס נתיב קובץ");
                string path = Console.ReadLine();
                File.ReadAllText(path);
                Console.Read();
            
        }
    }
}
