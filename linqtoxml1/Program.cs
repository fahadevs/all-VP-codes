using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace linqtoxml1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            XDocument xDocument = new XDocument(
                new XDeclaration("1.0","UTF-8","yes"),
                new XComment("Creating XML tree"),
                new XElement("Students",
                    new XElement("student", new XAttribute("id",1)),
                    new XElement("id", 1),
                    new XElement("name", "fahad"),
                    new XElement("marks", 900)));
            xDocument.Save(@"C:\Users\user\Desktop\database.xml");
        }
    }
}
