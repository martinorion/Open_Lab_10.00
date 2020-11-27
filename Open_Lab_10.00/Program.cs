using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();

            LOTR.author = "Holena";
            Console.WriteLine(LOTR.author);

            LOTR.category = "Turorial";
            Console.WriteLine(LOTR.category);

            LOTR.pages += 5;
            Console.WriteLine(LOTR.pages);

            LOTR.releaseDate += 1400;
            Console.WriteLine(LOTR.releaseDate);

            LOTR.title = "Armagedon";
            Console.WriteLine(LOTR.title);



            Book LOTR2 = new Book();


            Book LOTR3 = new Book("Kravina", 60);


            Book HOBIT = new Book("Somarina", 88, "Roman", "Botto", 2000);

            Console.WriteLine("");
            Console.WriteLine("LOTR2: " + LOTR2.ToString());
            Console.WriteLine("");
            Console.WriteLine("LOTR3: " + LOTR3.ToString());
            Console.WriteLine("");
            Console.WriteLine("HOBIT: " + HOBIT.ToString());


        }

    }
}
