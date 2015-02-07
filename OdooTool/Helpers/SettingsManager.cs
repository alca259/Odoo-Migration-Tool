using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using PostgreSQLConnect.Models;

namespace OdooTool.Helpers
{
    public static class SettingsManager
    {
        #region Constants
        private const string _fileName = "Settings.xml";
        private const string _folderName = "AppData";
        #endregion

        #region Vars
        private static string _fullDirPath;
        private static string _fullFilePath;
        #endregion

        #region Utils file & directory
        public static void Initialize()
        {
            _fullDirPath = Path.Combine(Application.StartupPath, _folderName);
            _fullFilePath = Path.Combine(_fullDirPath, _fileName);
        }
        
        private static void CheckIfDirectoryExists()
        {
            if (!Directory.Exists(_fullDirPath)) Directory.CreateDirectory(_fullDirPath);
        }

        private static bool CheckIfFileExists()
        {
            return File.Exists(_fullFilePath);
        }
        #endregion

        #region Load & Save XML
        public static SettingsModel GetXml()
        {
            // Comprobamos si existe el directorio
            CheckIfDirectoryExists();

            // Si no existe el fichero devolvemos
            if (!CheckIfFileExists()) return null;

            // Cargamos el fichero XML
            XDocument doc = XDocument.Load(_fullFilePath);

            var elementNode = doc.Descendants("Settings").First();

            SettingsModel model = new SettingsModel
            {
                Host = (string) elementNode.Attribute("HOST"),
                Port = (int) elementNode.Attribute("PORT"),
                User = (string) elementNode.Attribute("USER"),
                Password = (string) elementNode.Attribute("PASS"),
                Database = (string) elementNode.Attribute("DB")
            };

            return model;
        }

        public static void SetXml(SettingsModel x)
        {
            // Comprobamos si existe el directorio
            CheckIfDirectoryExists();

            // Si existe el fichero, lo borramos
            if (CheckIfFileExists())
            {
                File.Delete(_fullFilePath);
            }

            // Creamos un nuevo XDocument
            XDocument xDocument = new XDocument();

            // Creamos un elemento
            XElement sectionXML = new XElement("SettingsData", (
                new XElement("Settings",
                    new XAttribute("HOST", x.Host ?? ""),
                    new XAttribute("PORT", x.Port),
                    new XAttribute("USER", x.User ?? ""),
                    new XAttribute("PASS", x.Password ?? ""),
                    new XAttribute("DB", x.Database ?? "")
            )));

            // Lo añadimos al XDocument
            xDocument.Add(sectionXML);

            // Guardamos el XDocument en disco
            xDocument.Save(_fullFilePath, SaveOptions.None);
        }
        #endregion
    }
}
