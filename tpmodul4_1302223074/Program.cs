public class Program
{
    public enum Kelurahan { 
        Batununggal, Kujangsari, Mengger, Wates,
        Cijaura, Jatisari, Margasari, Sekejati,
        Kebonwaru, Maleer, Samoja
    }
    public class KodePos
    {
        public Kelurahan kelurahan;
        public KodePos(Kelurahan inputKelurahan)
        {
            this.kelurahan = inputKelurahan;
        }
        int[] nomorKodePos = {
            40266, 40287, 40267, 40256,
            40287, 40286, 40286, 40286,
            40272, 40274, 40273
        };

        public int getKodePos()
        {
            return nomorKodePos[(int)kelurahan];
        }
    }
    public static void Main(string[] args)
    {
        KodePos k1 = new KodePos(Kelurahan.Batununggal);
        Console.WriteLine("Kelurahan " + k1.kelurahan + " memiliki kode pos: " + k1.getKodePos());
    }
}