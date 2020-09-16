using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System.Net;

namespace LaunchGame.Classes
{
    public class ConfigManager
    {
        //TODO Check version control level from file in google docs.
        public string ConfigKey { get; set; }
        public string ConfigValue { get; set; }

        public ConfigManager()
        {
            if (!File.Exists("config.txt"))
            {
                var newConfigFile = File.Create("config.txt");
                newConfigFile.Close();
            }
        }

        public string ReadKey(string keyToRead)
        {
            string result = "";
            Dictionary<string, string> config = new Dictionary<string, string>(GetEntireConfig());
            config.TryGetValue(keyToRead, out result);
            return result;
        }
        public void AddKey(string keyToAdd, string keyValueToAdd)
        {
            try
            {
                Dictionary<string, string> config = new Dictionary<string, string>(GetEntireConfig());
                string configItem = ReadKey(keyToAdd);
                if (configItem != "")
                {
                    //Add the key
                    config.Add(keyToAdd, keyValueToAdd);
                    UpdateConfig(config);
                }
                else
                {
                    throw new System.InvalidOperationException("Key already exists");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void DeleteKey(string keyToDelete, string keyValueToDelete)
        {
            Dictionary<string, string> config = new Dictionary<string, string>(GetEntireConfig());
            string configItem = ReadKey(keyToDelete);
            if (configItem != "")
            {
                //Delete the key
                config.Remove(keyToDelete);
                UpdateConfig(config);
            }
        }
        public void UpdateKey(string keyToUpdate, string keyValueToUpdate)
        {
            var currentValue = ReadKey(keyToUpdate);
            if (currentValue != "")
            {
                Dictionary<string, string> configItem = new Dictionary<string, string>(GetEntireConfig());

                configItem[keyToUpdate] = keyValueToUpdate;
                UpdateConfig(configItem);
            }
            else
            {
                AddKey(keyToUpdate, keyValueToUpdate);
            }
        }




        private void UpdateConfig(Dictionary<string, string> configToUpdate)
        {

            var newFile = File.Create("config_new.txt");
            newFile.Close();
            List<string> configLines = new List<string>();
            foreach (var row in configToUpdate)
            {
                string key = row.Key;
                string value = row.Value;
                configLines.Add(key + ":" + value);
            }

            File.AppendAllLines("config_new.txt", configLines);
            File.Delete("config.txt");
            File.Move("config_new.txt", "config.txt");

        }

        public Dictionary<string, string> GetEntireConfig()
        {
            Dictionary<string, string> configs = new Dictionary<string, string>();
            string[] contents = File.ReadAllLines("config.txt");
            foreach (var row in contents)
            {
                var delimiterValue = row.ToString().IndexOf(":");
                var keyFound = row.Substring(0, delimiterValue);
                var dataFound = row.Substring(delimiterValue + 1);
                configs.Add(keyFound, dataFound);
            }
            return configs;
        }
        //public Dictionary<string, string> GetEntireConfig(string file)
        //{
        //    using (var client = new WebClient())
        //    {
        //        client.DownloadFile(file, "conanLauncherVersion.txt");
        //    }
        //    Dictionary<string, string> configs = new Dictionary<string, string>();
        //    string[] contents = File.ReadAllLines(file);
        //    foreach (var row in contents)
        //    {
        //        var delimiterValue = row.ToString().IndexOf(":");
        //        var keyFound = row.Substring(0, delimiterValue);
        //        var dataFound = row.Substring(delimiterValue + 1);
        //        configs.Add(keyFound, dataFound);
        //    }
        //    return configs;
        //}



        public void SeedDefaultConfigFile()
        {

        }
    }
}
