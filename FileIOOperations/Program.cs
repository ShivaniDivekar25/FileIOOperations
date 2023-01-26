namespace FileIOOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File IO Operations");
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("1:File Exists\n2:Read All Lines\n3:Read All Text\n4:Copy Existing File\n5:Delete Existing File\n6:Read from Stream Reader\n7:File Stream Writer\n8:Binary Data Serialize\n9:Binary Data DeSerailize");
            int option = Convert.ToInt32(Console.ReadLine());
            string path = "C:\\Users\\hp\\source\\repos\\FileIOOperations\\FileIOOperations\\Sample.Txt";
            //Switch case to call different method
            switch (option)
            {
                case 1:
                    FileOperations.FileExists(path);
                    break;
                case 2:
                    FileOperations.ReadAllLines(path);
                    break;
                case 3:
                    FileOperations.ReadAllLinesAtOnce(path);
                    break;
                case 4:
                    string path1 = "C:\\Users\\hp\\source\\repos\\FileIOOperations\\FileIOOperations\\Sample.Txt";
                    FileOperations.CopyAnExistingFile(path1);
                    break;
                case 5:
                    FileOperations.DeleteFile();
                    break;
                case 6:
                    FileOperations.ReadFromStreamReader(path);
                    break;
                case 7:
                    FileOperations.FileStreamWriter(path);
                    break;
                case 8:
                    BinaryDataOperation.BinaryDataSerialize();
                    break;
                case 9:
                    BinaryDataOperation.BinaryDataDeSerailize();
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
        }
    }
}