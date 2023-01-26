using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    //Created Class
    public class FileOperations
    {
        //Created File Exists Method
        public static bool FileExists(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    Console.WriteLine("Given file exists");
                    return true;
                }
                else
                {
                    Console.WriteLine("Given file is not exists");
                    return false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default;
        }
    }
}
