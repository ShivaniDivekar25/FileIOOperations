using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    //Created class
    public class BinaryDataOperation 
    {
        //Created Binary Serialization method
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
        //Created Binary Deserialization method
        public static void BinaryDataDeSerailize()
        {
            try
            {
                string path = "C:\\Users\\hp\\source\\repos\\FileIOOperations\\FileIOOperations\\Sample.Txt";
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);
                List<Contact> listOfContacts = (List<Contact>)binaryFormatter.Deserialize(stream);
                foreach (Contact contact in listOfContacts)
                {
                    Console.WriteLine(contact);
                }
            }
            catch (ArgumentNullException ex)
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
