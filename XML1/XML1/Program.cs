using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XML1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Configuraciones.xml");
                XmlNodeList configSections = doc.SelectNodes("/configurations/configsection");
                foreach (XmlNode configSection in configSections)
                {
                    string name = configSection.Attributes["name"].Value;
                    Console.WriteLine(name);
                    foreach (XmlNode nodes in configSection.ChildNodes)
                    {
                        Console.WriteLine(nodes.InnerText);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo XML: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
