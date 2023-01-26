namespace FileIOOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File IO Operations");
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("\n1:File Exists");
            int option = Convert.ToInt32(Console.ReadLine());
            string path = "C:\\Users\\hp\\source\\repos\\FileIOOperations\\FileIOOperations\\Program.cs";
            //Switch case to call different method
            switch (option)
            {
                case 1:
                    FileOperations.FileExists(path);
                    break;
            }
        }
    }
}