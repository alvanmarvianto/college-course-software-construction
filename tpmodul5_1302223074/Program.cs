class Program
{
    public class DataGeneric<T>
    {
        T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine();
        DataGeneric<string> dataObj = new DataGeneric<string>("1302223074");
        dataObj.PrintData();
    }
}