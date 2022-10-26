namespace AlgoritmProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your choice:\n1.Insertion Sort\n2.Bubble Sort\n3.Binary search\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------");
            switch (choice)
            {
                
                case 1:
                    const string FILE_PATH = @"C:\Users\yash dondal\Desktop\208\DataStructure_DAY16,17\New.txt\";
                    BinarySearch search = new BinarySearch();
                    search.Search(FILE_PATH);
                    break;
                default:
                    break;
            }
        }


    }
}