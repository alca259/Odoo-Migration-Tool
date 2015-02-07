using System.Collections.Generic;
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
        public static SettingsModel GetXml(bool isDestination = false)
        {
            // Comprobamos si existe el directorio
            CheckIfDirectoryExists();

            // Si no existe el fichero devolvemos
            if (!CheckIfFileExists()) return null;

            // Cargamos el fichero XML
            XDocument doc = XDocument.Load(_fullFilePath);

            var models = doc.Descendants("Settings").Select(s => new SettingsModel
            {
                Host = (string) s.Attribute("HOST"),
                Port = (int) s.Attribute("PORT"),
                User = (string) s.Attribute("USER"),
                Password = (string) s.Attribute("PASS"),
                Database = (string) s.Attribute("DB"),
                Destiny = (string) s.Attribute("DESTINY")
            });

            return !isDestination ? models.FirstOrDefault(f => f.Destiny == "SOURCE") : models.FirstOrDefault(f => f.Destiny == "DESTINATION");
        }

        public static void SetXml(SettingsModel x)
        {
            // Comprobamos si existe el directorio
            CheckIfDirectoryExists();

            List<SettingsModel> models = new List<SettingsModel>();

            // Si existe el fichero, lo borramos
            if (CheckIfFileExists())
            {
                // Cargamos el fichero XML
                XDocument doc = XDocument.Load(_fullFilePath);

                // Obtenemos los datos cargados
                models = doc.Descendants("Settings").Select(s => new SettingsModel
                {
                    Host = (string)s.Attribute("HOST"),
                    Port = (int)s.Attribute("PORT"),
                    User = (string)s.Attribute("USER"),
                    Password = (string)s.Attribute("PASS"),
                    Database = (string)s.Attribute("DB"),
                    Destiny = (string)s.Attribute("DESTINY")
                }).ToList();

                // Dependiendo de que vayamos a cargar, lo eliminamos
                var toRemove = models.FirstOrDefault(s => s.Destiny == x.Destiny);
                if (toRemove != null)
                    models.Remove(toRemove);

                // Borramos el fichero
                File.Delete(_fullFilePath);
            }

            // Añadimos el actual
            models.Add(x);

            // Creamos un nuevo XDocument
            XDocument xDocument = new XDocument();

            // Creamos un elemento
            XElement sectionXML = new XElement("SettingsData", (
                models.Select(y => new XElement("Settings",
                    new XAttribute("HOST", y.Host ?? "127.0.0.1"),
                    new XAttribute("PORT", y.Port),
                    new XAttribute("USER", y.User ?? "postgres"),
                    new XAttribute("PASS", y.Password ?? ""),
                    new XAttribute("DB", y.Database ?? "postgres"),
                    new XAttribute("DESTINY", y.Destiny ?? "SOURCE")
            ))));

            // Lo añadimos al XDocument
            xDocument.Add(sectionXML);

            // Guardamos el XDocument en disco
            xDocument.Save(_fullFilePath, SaveOptions.None);
        }
        #endregion
    }
}
