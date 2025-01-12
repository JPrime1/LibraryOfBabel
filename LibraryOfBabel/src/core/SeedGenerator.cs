using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfBabel.src.core
{
    internal class SeedGenerator
    {
        public SeedGenerator() { 
        }

        public static int GenerateSeed()
        {
            return 0;
        }

        public static int GenerateSeed(BookId book)
        {
            return SeedGenerator.CalculateSeed(book);
        }

        private static int CalculateSeed(BookId book)
        {
            return book.RoomX * 73856093 ^ book.RoomY * 19349663 ^ book.WallDirection * 83492791 ^ book.ShelfLevel * 1234567 ^ book.BookNumber * 9876543 ^ book.CurrentPage * 54321;
        }
    }
}
