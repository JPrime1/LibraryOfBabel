using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfBabel.src.core
{
    internal class BookId
    {
        private int roomX;
        private int roomY;
        private int wallDirection;
        private int shelfLevel;
        private int bookNumber;
        private int currentPage;

        public BookId(){
            RoomX = 0;
            RoomY = 0;
            WallDirection = 0;
            ShelfLevel = 0;
            BookNumber = 0;
            CurrentPage = 0;
        }

        public int RoomX { get { return roomX; } set { roomX = value; } }
        public int RoomY { get { return roomY; } set {roomY = value; } }
        public int WallDirection { get { return wallDirection; } set { wallDirection = value; } }
        public int ShelfLevel { get { return shelfLevel; } set { shelfLevel = value; } }
        public int BookNumber { get { return bookNumber; } set { bookNumber = value; } }
        public int CurrentPage { get { return currentPage; } set { currentPage = value; } }

        public void update(int[] id) { 
            RoomX = id[0]; RoomY = id[1]; WallDirection = id[2]; ShelfLevel = id[3]; BookNumber = id[4]; CurrentPage = id[5];
        }

    }
}
