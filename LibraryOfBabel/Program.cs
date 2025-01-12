using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryOfBabel.src.core;

namespace LibraryOfBabel
{
    class Program
    {
        static void Main(string[] args)
        {
            //some notes from book
            //each book 410 pages, 40 lines per page, 80 char per line

            //256 or 512 per book?
            //32 lines of 64 char? per page? is 2048 char total compared to 3200 above

            BookId bookId = new();
            string input;

            while (true) {
                Console.Write("Book ID (roomx roomy wallDir shelfLVL Num pg): ");
                input = Console.ReadLine();

                if (input == null || input=="" || input=="exit") {break;}

                args = input?.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int[] id = args.Select(int.Parse).ToArray();
                bookId.update(id);

                string text = TextGenerator.GenerateText(SeedGenerator.GenerateSeed(bookId));
                Console.WriteLine(text);
            }




        }
    }
}