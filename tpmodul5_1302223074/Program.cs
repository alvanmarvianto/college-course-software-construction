class Program
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T inputUser)
        {
            Console.WriteLine("Halo user " + inputUser);
        }
    }
    static void Main(string[] args)
    {
        String nama = "Alvan";
        HaloGeneric sapaObj = new HaloGeneric();
        sapaObj.SapaUser(nama);
    }
}