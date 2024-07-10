
using AljabarLibraries;

double[] persKuadrat = { 1, -3, -10 };
double[] kuadrat = { 2, -3 };

double[] AkarPersamaanKuadrat = Kuadrat.AkarPersamaanKuadrat(persKuadrat);
double[] HasilKuadrat = Kuadrat.HasilKuadrat(kuadrat);

Console.WriteLine("{" + AkarPersamaanKuadrat[0] + ", " + AkarPersamaanKuadrat[1] + "}");
Console.WriteLine("{" + HasilKuadrat[0] + ", " + HasilKuadrat[1] + ", " + HasilKuadrat[2] + "}");
