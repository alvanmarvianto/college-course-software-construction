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

    public enum KarakterState
    {
        Tengkurap, Jongkok, Berdiri, Terbang
    }
    public enum Trigger
    {
        TombolW, TombolS, TombolX
    }

    public class PosisiKarakterGame
    {
        public class Transistion
        {
            public KarakterState stateAwal;
            public KarakterState stateAkhir;
            public Trigger trigger;

            public Transistion(KarakterState stateAwal, KarakterState stateAkhir, Trigger trigger)
            {
                this.stateAwal = stateAwal;
                this.stateAkhir = stateAkhir;
                this.trigger = trigger;
            }
        }

        Transistion[] transisi =
        {
            new Transistion(KarakterState.Tengkurap, KarakterState.Jongkok, Trigger.TombolW),
            new Transistion(KarakterState.Jongkok, KarakterState.Tengkurap, Trigger.TombolS),
            new Transistion(KarakterState.Jongkok, KarakterState.Berdiri, Trigger.TombolW),
            new Transistion(KarakterState.Berdiri, KarakterState.Jongkok, Trigger.TombolS),
            new Transistion(KarakterState.Berdiri, KarakterState.Terbang, Trigger.TombolW),
            new Transistion(KarakterState.Terbang, KarakterState.Berdiri, Trigger.TombolS),
            new Transistion(KarakterState.Terbang, KarakterState.Jongkok, Trigger.TombolX)
        };

        public KarakterState currentState = KarakterState.Berdiri;

        public KarakterState nextState(KarakterState stateAwal, Trigger trigger)
        {
            KarakterState stateAkhir = stateAwal;
            for (int i = 0; i < transisi.Length; i++)
            {
                Transistion perubahan = transisi[i];
                if (stateAwal == perubahan.stateAwal && trigger == perubahan.trigger)
                {
                    stateAkhir = perubahan.stateAkhir;
                }
            }
            return stateAkhir;
        }

        public void activeTrigger(Trigger trigger)
        {
            currentState = nextState(currentState, trigger);
           if(trigger == Trigger.TombolW)
            {
                Console.WriteLine("Tombol arah atas ditekan");
            } else if (trigger == Trigger.TombolS)
            {
                Console.WriteLine("Tombol arah bawah ditekan");
            }
            Console.WriteLine("Posisi anda sedang " + currentState + " karena anda " + trigger);
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        KodeBuah b1 = new KodeBuah(NamaBuah.Pisang);
        Console.WriteLine("Buah " + b1.namaBuah + " memiliki kode: " + b1.getKodeBuah());
        Console.WriteLine();
        
        PosisiKarakterGame k1 = new PosisiKarakterGame();
        Console.WriteLine("Posisi anda sedang " + k1.currentState);
        Console.WriteLine();

        k1.activeTrigger(Trigger.TombolS);
        k1.activeTrigger(Trigger.TombolS);
        k1.activeTrigger(Trigger.TombolW);
        k1.activeTrigger(Trigger.TombolW);
        k1.activeTrigger(Trigger.TombolW);
        k1.activeTrigger(Trigger.TombolS);
        k1.activeTrigger(Trigger.TombolW);
        k1.activeTrigger(Trigger.TombolX);
    }
}