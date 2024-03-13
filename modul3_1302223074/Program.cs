public class Program
{
    public enum NamaBuah
    {
        Apel, Aprikot, Alpukat, 
        Pisang, Paprika, Blackberry,
        Ceri, Kelapa, Jagung
    }

    public class KodeBuah
    {
        public NamaBuah namaBuah;
        public KodeBuah(NamaBuah namaBuah)
        {
            this.namaBuah = namaBuah;
        }
        String[] nomorKodeBuah = {
            "A00", "B00", "C00",
            "D00", "E00", "F00",
            "H00", "I00", "J00"
        };
        public String getKodeBuah()
        {
            return nomorKodeBuah[(int)namaBuah];
        }
    }

    public static void Main(string[] args)
    {
        KodeBuah b1 = new KodeBuah(NamaBuah.Pisang);
        Console.WriteLine("Buah " + b1.namaBuah + " memiliki kode: " + b1.getKodeBuah());
        Console.WriteLine();
    }
}