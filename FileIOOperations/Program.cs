namespace FileIOOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File IO Operations");
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("\n1:File Exists\n2:Read All Lines\n3:Read All Text");
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
            }
        }
    }
}