namespace LinkedList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<int> testList = new LinkedList<int>();
            testList.AddNode(123);
            testList.AddNode(1111);
            testList.AddNode(777);
            
            testList.PrintList();
        }
    }
}