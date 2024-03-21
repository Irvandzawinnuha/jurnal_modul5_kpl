using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using static Penjumlahan;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine(Penjumlahan.JumlahTigaAngka<int>(13, 02, 22));
        SimpleDataBase<int> data = new SimpleDataBase<int>();
        data.AddNewData(12);
        data.AddNewData(13);
        data.AddNewData(14);
        data.PrintAllData();
    }
}

public class Penjumlahan 
 {
 
    public static T JumlahTigaAngka<T> (T Data1, T Data2, T Data3)
    {
        dynamic angka1 = Data1;
        dynamic angka2 = Data2;
        dynamic angka3 = Data3;
        dynamic hasil = angka1 + angka2 + angka3;

        return hasil;
       
    }
    public class SimpleDataBase<T>
    {

        private List<T> storedData;
        private List<DateTime> inputDates;
        public SimpleDataBase()
        {
            storedData = new List<T> ();
            inputDates = new List<DateTime>();
        }
        public void AddNewData(T Data)
        {
            storedData.Add (Data);
            inputDates.Add (DateTime.Now);
        }
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data "+ i+ "berisi :"+ storedData[i]+ " yang disimpan pada waktu UTC: " + inputDates[i]);
            }

        }

    }

   
    

}

