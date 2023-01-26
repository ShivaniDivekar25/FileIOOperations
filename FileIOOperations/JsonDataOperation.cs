using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    //Created class
    public class JsonDataOperation
    {
        //Created Json Data serialize method
        public static string path = "C:\\Users\\hp\\source\\repos\\FileIOOperations\\FileIOOperations\\Sample.Txt";
        public static void JsonDataSerialze()
        {
            try
            {
                List<Contact> contact = new List<Contact>()
                {
                new Contact(){ID=1,Name="Sindhu",Address="Banglr"},
                new Contact(){ID=2,Name="Haresh",Address="Mumbai"}
                };
                string jsonData = JsonConvert.SerializeObject(contact);
                File.WriteAllText(path, jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Created Json Data DeSerialize
        public static void JsonDataDeSerialize()
        {
            try
            {
                string jsonData = File.ReadAllText(path);
                List<Contact> list = JsonConvert.DeserializeObject<List<Contact>>(jsonData);
                foreach (Contact contact in list)
                {
                    Console.WriteLine(contact);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
