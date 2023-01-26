using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    public class BinaryDataOperation
    {
        public static void BinaryDataSerialize()
        {
            try
            {
                string path = "C:\\Users\\hp\\source\\repos\\FileIOOperations\\FileIOOperations\\Sample.Txt";
                List<Contact> contact = new List<Contact>()
                {
                new Contact(){ID=1,Name="Sindhu",Address="Banglr"},
                new Contact(){ID=2,Name="Haresh",Address="Mumbai"}
                };
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
                binaryFormatter.Serialize(stream, contact);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
