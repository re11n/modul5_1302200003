// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        double xi = double.Parse(Console.ReadLine());
        double yi = double.Parse(Console.ReadLine());
        double zi = double.Parse(Console.ReadLine());

        Penjumlahan < Double > tes = new Penjumlahan<Double>();
        tes.JumlahTigaAngka(xi, yi, zi);
       
    }

    class Penjumlahan<T>
    {

        public void JumlahTigaAngka(double x, double y, double z)
        {
            double temp = x + y + z;
            Console.WriteLine(temp);
        }
    }
}

