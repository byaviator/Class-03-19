namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Asus","Rog", 10, 1000, 512, 16);
            notebook.Sale();
            notebook.ShowFulldata();
        }
    }
}
