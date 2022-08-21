
using Deneme;

int i, sayac = 1;
    Console.WriteLine("Kaça kadar yazdırsın");
    int e_kadar = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Kaçar Kaçar yazdırsın");
    int aritma = Convert.ToInt32(Console.ReadLine());
    for (i = 0; i <= e_kadar; i = i + aritma)
    {
        Console.WriteLine($"{sayac}. sayi ={i}");
        sayac++;
    }
    Console.WriteLine("İşlem başarılı :)");
Add();
Console.WriteLine(TOPLAMA()); 
Class1 class1 = new Class1();
class1.Id = 1;
class1.Name = "Yasin";

 


void Add()
{
    Console.WriteLine("fonk çalıştı");
}
int TOPLAMA()
{
    int i = 10;
    return i;
}
void Acaba()
{
    Console.WriteLine(class1.Id);
    Console.WriteLine(class1.Name);
    class1.birde();
}
Acaba();

