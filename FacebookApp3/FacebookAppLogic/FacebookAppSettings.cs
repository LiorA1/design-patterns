using System;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace FacebookAppLogic
{
    public class FacebookAppSettings
    {
        private const string k_AppSettingsFileName = "appSettings.xml";

        public bool LoggedIn { get; set; }

        public bool RememberUser { get; set; }

        public Point LastWindowLocation { get; set; }

        public Size LastWindowSize { get; set; }

        private FacebookAppSettings()
        {
            LastWindowLocation = new Point(10, 10);
            LastWindowSize = new Size(855, 749);
            RememberUser = false;
            LoggedIn = false;
        }
        
        /* Load Settings from a file, if it not exists - create defualt Settings. */
        public static FacebookAppSettings LoadAppSettingsFromFile()
        {
            FacebookAppSettings obj;

            try
            {
                using (Stream fileStream = new FileStream(k_AppSettingsFileName, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(FacebookAppSettings));
                    obj = serializer.Deserialize(fileStream) as FacebookAppSettings;
                }

                return obj;
            }
            catch 
            {
                obj = new FacebookAppSettings();
                return obj;
            }
        }

        /* Saves the Settings to a file*/
        public void SaveAppSettingsToFile()
        {
            try
            {
                Stream fileStream;

                if (this.RememberUser)
                {
                    //// Delete the previuos data(if exists) and THEN save.
                    if (File.Exists(k_AppSettingsFileName))
                    {
                        fileStream = new FileStream(k_AppSettingsFileName, FileMode.Truncate);
                    }
                    else
                    {
                        fileStream = new FileStream(k_AppSettingsFileName, FileMode.Create);
                    }

                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(fileStream, this);
                }
                else
                {
                    if (File.Exists(k_AppSettingsFileName))
                    {
                        File.Delete(k_AppSettingsFileName);
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
