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

        /// <summary>
        /// Generates psudorandom seed value dependent on BookID attributes
        /// </summary>
        /// <param name="book">Book Parameter</param>
        /// <returns>Seed Integer</returns>
        public static int GenerateSeed(BookId book)
        {
            return SeedGenerator.CalculateSeed(book);
        }

        /// <summary>
        /// Internal helper function, calculating the seed value given BookID
        /// </summary>
        /// <param name="book">Book Parameter</param>
        /// <returns>Calculated Int Seed Result</returns>
        private static int CalculateSeed(BookId book)
        {
            return book.RoomX * 73856093 ^ book.RoomY * 19349663 ^ book.WallDirection * 83492791 ^ book.ShelfLevel * 1234567 ^ book.BookNumber * 9876543 ^ book.CurrentPage * 54321;
        }
    }
}
