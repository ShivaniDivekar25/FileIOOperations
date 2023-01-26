using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIOOperations
{
    //Created class
    public class XmlDataOperation
    {
        public static string path = "C:\\Users\\hp\\source\\repos\\FileIOOperations\\FileIOOperations\\Sample.Txt";
        //Created method for Xml Data Serialize
        public static void XmlDataSerialize()
        {
            try
            {
                List<Contact> contact = new List<Contact>()
                {
                new Contact(){ID=1,Name="Sindhu",Address="Banglr"},
                new Contact(){ID=2,Name="Haresh",Address="Mumbai"}
                };
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Contact>));
                StreamWriter sw = new StreamWriter(path);
                xmlSerializer.Serialize(sw, contact);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
