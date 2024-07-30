using System;

namespace operatorler
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Atama ve İşlemli Atama***");
            // Atama Ve işlemli atama

            int x = 3;
            int y = 3;

            Console.WriteLine(y);                          
            y = y+2;
            y += 2;

            Console.WriteLine(y);

            y /= 1;

            Console.WriteLine(y);

            x *=5;

            Console.WriteLine(x);

             Console.WriteLine("***Mantıksal Operatörler***");

            //Mantıksal Operatörler
            
            bool isSucces = true;
            bool isCompleted = false;

            if(isSucces && isCompleted)
            Console.WriteLine("Perfect");

            if(isSucces || isCompleted)
            Console.WriteLine("Great!");

            if(isSucces && !isCompleted)
            Console.WriteLine("Fine!");

             Console.WriteLine("***İlişkisel Operatörler***");
            // İlişkisel Operatörler 
            
            int a = 3;
            int b = 81;
            bool sonuc = a<b;

            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a<b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);




        }
    }
}