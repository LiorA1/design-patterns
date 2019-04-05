using System;
using System.IO;
using System.Xml.Serialization;

namespace FacebookAppLogic
{
    public class FacebookEngineSettings
    {
        private const string k_EngineSettingsFileName = "engineSettings.xml";

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        private FacebookEngineSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
        }
       
        /* Load Settings from a file, if it not exists - create defualt Settings. */
        public static FacebookEngineSettings LoadEngineSettingsFromFile()
        {
            FacebookEngineSettings obj;

            try
            {
                using (Stream fileStream = new FileStream(k_EngineSettingsFileName, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(FacebookEngineSettings));
                    obj = serializer.Deserialize(fileStream) as FacebookEngineSettings;
                    fileStream.Dispose();
                }

                return obj;
            }
            catch
            {
                obj = new FacebookEngineSettings();
                return obj;
            }
        }

        /* Saves the Engine Settings to a file*/
        public void SaveEngineSettingsToFile()
        {
            // Stream fileStream;
            try
            {
                Stream fileStream;

                if (this.RememberUser)
                {
                    // Delete the previuos data(if exists) and THEN save.
                    if (File.Exists(k_EngineSettingsFileName))
                    {
                        fileStream = new FileStream(k_EngineSettingsFileName, FileMode.Truncate);
                    }
                    else
                    {
                        fileStream = new FileStream(k_EngineSettingsFileName, FileMode.Create);
                    }

                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(fileStream, this);
                }
                else
                {
                    if (File.Exists(k_EngineSettingsFileName))
                    {
                        File.Delete(k_EngineSettingsFileName);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }      
    }
}
