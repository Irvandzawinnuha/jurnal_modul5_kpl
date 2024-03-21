using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine(Penjumlahan.JumlahTigaAngka<int>(13, 02, 22));
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

   
    

}

