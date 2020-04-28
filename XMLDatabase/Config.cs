using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLDatabase
{
    public class Config
    {
        public static Config instance = new Config();

        private XDocument configDoc;

        private readonly string configPath;

        private Config()
        {
            configPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase+"config.xml";
            configDoc = XDocument.Load(configPath);
        }

        public string GetPreFile()
        {
            return configDoc.Root.Element("pre-file").Value;
        }

        public void SaveConfig(string preFile)
        {
            configDoc.Root.Element("pre-file").Value = preFile;
            configDoc.Save(configPath);
        }
    }
}
