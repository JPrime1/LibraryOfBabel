using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfBabel.src.core
{
    internal class BookId
    {
        public BookId(){
            RoomX = 0;
            RoomY = 0;
            WallDirection = 0;
            ShelfLevel = 0;
            BookNumber = 0;
            CurrentPage = 0;
        }

        public int RoomX { get; set; }
        public int RoomY { get; set; }
        public int WallDirection { get; set; }
        public int ShelfLevel { get; set; }
        public int BookNumber { get; set; }
        public int CurrentPage { get; set; }

        public void Update(int[] id) { 
            RoomX = id[0]; RoomY = id[1]; WallDirection = id[2]; ShelfLevel = id[3]; BookNumber = id[4]; CurrentPage = id[5];
        }

    }
}
