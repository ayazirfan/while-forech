using System.Reflection.PortableExecutable;

internal class Program
{
    private static void Main(string[] args)
    {
        // 1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console yazdıran program.
        /*Console.Write("Bir Sayı Giriniz:");

        int sayi = int.Parse(Console.ReadLine());
        int sayac = 1;
        int toplam = 0;
        while (sayac < sayi)

        {
            toplam += sayac;
            sayac++;

        }
        Console.WriteLine(toplam / sayi);
        */

        // 'a' dan 'z' ye kadar tüm harfleri console a yazdır. 
        /*
       
         char chracter = 'a';
         while (character < 'z')
         {
            Console.Write(chracter);
            chracter ++;
        
         }
         */


         

         Console.WriteLine("*****Foreach****");
         string [] arabalar = {"BMV", "FORD", "TOYOTA", "NİSSAN"};

         foreach (var araba in arabalar)
         {
            Console.WriteLine(araba);
         }
         
    }
}