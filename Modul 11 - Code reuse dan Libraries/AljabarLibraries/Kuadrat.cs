namespace AljabarLibraries
{
    public class Kuadrat
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];
            double[] hasil = new double[2];

            hasil[0] = (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
            hasil[1] = (-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
            return hasil;
        }
        public static double[] HasilKuadrat(double[] kuadrat)
        {
            double a = kuadrat[0];
            double b = kuadrat[1];
            double[] hasil = new double[3];

            hasil[0] = Math.Pow(a, 2);
            hasil[1] = 2 * a * b;
            hasil[2] = Math.Pow(b, 2);
            return hasil;
        }
    }
}
