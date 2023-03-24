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
        
        SimpleDataBase<String> data = new SimpleDataBase<String>();
        data.AddNewData("13");
        data.AddNewData("02");
        data.AddNewData("20");
        data.PrintAllData();
    }

    public class SimpleDataBase <T>
    {
        private List<T> storedData = new List<T>();
        private List<DateTime> inputDates = new List<DateTime>();

        public SimpleDataBase()
        {
            List<T> storedData = new List<T>();
        }


        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.UtcNow);
        }

        public void PrintAllData()
        {
            int temp = 0;
            foreach (T data in storedData)
            {
                int datatemp = temp + 1;
                Console.WriteLine("Data " + datatemp + " berisi: "+ datatemp +", yang disimpan pada waktu " + inputDates[temp]);
                temp++;
            }
        }

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
