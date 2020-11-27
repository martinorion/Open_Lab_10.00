using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Author("Holena");
            LOTR.Category("Tutorial");
            LOTR.Pages(88);
            LOTR.RealeaseDate("2020");
            LOTR.Title("Armagedon");
            Console.WriteLine(LOTR.ToString());
            Console.ReadKey();


        }
    }
}
