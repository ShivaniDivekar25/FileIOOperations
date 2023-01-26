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
        //Created method to read all lines
        public static void ReadAllLines(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    string[] lines = File.ReadAllLines(path);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Created method to read all text
        public static void ReadAllLinesAtOnce(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    string lines = File.ReadAllText(path);
                    Console.WriteLine(lines);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Created method to copy an existing file
        public static void CopyAnExistingFile(string path)
        {
            try
            {
                string destination = "C:\\Users\\hp\\source\\repos\\FileIOOperations\\FileIOOperations\\Destination.txt";
                if (File.Exists(path))
                {
                    File.Copy(path, destination);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
