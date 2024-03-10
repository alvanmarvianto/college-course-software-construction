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

    public enum DoorState{Terkunci, Terbuka}
    public enum DoorTrigger{KunciPintu, BukaPintu}
    public class DoorMachine
    {
        public class Transition
        {
            public DoorState stateAwal;
            public DoorState stateAkhir;
            public DoorTrigger trigger;

            public Transition(DoorState stateAwal, DoorState stateAkhir, DoorTrigger trigger)
            {
                this.stateAwal = stateAwal;
                this.stateAkhir = stateAkhir;
                this.trigger = trigger;
            }
        }

        Transition[] transisi =
        {
            new Transition(DoorState.Terkunci, DoorState.Terkunci, DoorTrigger.KunciPintu),
            new Transition(DoorState.Terkunci, DoorState.Terbuka, DoorTrigger.BukaPintu),
            new Transition(DoorState.Terbuka, DoorState.Terbuka, DoorTrigger.BukaPintu),
            new Transition(DoorState.Terbuka, DoorState.Terkunci, DoorTrigger.KunciPintu)
        };

        public DoorState currentState = DoorState.Terkunci;

        public DoorState GetNextState(DoorState stateAwal, DoorTrigger trigger)
        {
            DoorState stateAkhir = stateAwal;
            for (int i = 0; i < transisi.Length; i++)
            {
                Transition perubahan = transisi[i];
                if (stateAwal == perubahan.stateAwal && trigger == perubahan.trigger)
                {
                    stateAkhir = perubahan.stateAkhir;
                }
            }
            return stateAkhir;
        }

        public void ActiveTrigger(DoorTrigger trigger)
        {
            currentState = GetNextState(currentState, trigger);
            Console.WriteLine("Pintu anda " +  currentState + " karena anda " + trigger);
        }
    }

    public static void Main(string[] args)
    {
        KodePos k1 = new KodePos(Kelurahan.Batununggal);
        Console.WriteLine("Kelurahan " + k1.kelurahan + " memiliki kode pos: " + k1.getKodePos());
        Console.WriteLine();
    
        DoorMachine objPintu = new DoorMachine();
        Console.WriteLine("Pintu anda " + objPintu.currentState);
        objPintu.ActiveTrigger(DoorTrigger.KunciPintu);
        objPintu.ActiveTrigger(DoorTrigger.BukaPintu);
    }
}