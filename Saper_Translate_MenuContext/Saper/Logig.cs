using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    public class Logic
    {
        public int SIZE_X = 8;
        public int SIZE_Y = 8;

        //Вдкрита чи закрита клітка
        public bool[, ] isOpen;

    /*    private const int SYMB_NEGAT = -1;
        private const int SYMB_ZERO = 0;

        private const int CELL_SIZE = 30;
        private const int FIELD_X = 10;
        private const int FIELD_Y = 10;
        private const int DELTA = 2;*/

        public int ID_START = 6000;

        //
        private int[,] field; 

        public Logic()
        {
            initArrays();
        }

        public void init()
        {
            FieldSize size = ControlInfo.getInstance().GameSize;
            SIZE_X = size.Width;
            SIZE_Y = size.Height;

            initArrays();
            initField();
        }

        private void initArrays()
        {
            isOpen = new bool[SIZE_X, SIZE_Y];
            field = new int[SIZE_X, SIZE_Y];
        }

        public int[,] Field { get { return field; } }
        // public static int SIZE { get{ return SIZE; } }

        //========================================
        //Checks the cage for the presence of a mine.
        //If the output is beyond the boundary of the field, then returns  false
        public bool mine(int i, int j)
        {

            if ((i >= 0) && (i < SIZE_X))
            {
                if ((j >= 0) && (j < SIZE_Y))
                {
                    if (field[i, j] == -1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Checks the cage for emptiness. If out of bounds, then returns false
        public bool empty(int i, int j)
        {

            if ((i >= 0) && (i < SIZE_X))
            {
                if ((j >= 0) && (j < SIZE_Y))
                {
                    if (field[i, j] == 0)
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        // Заповнення поля цифрами
        public void initField()
        {
            int x, y, k = 0;

            for (int i = 0; i < SIZE_X; i++)
            {
                for (int j = 0; j < SIZE_Y; j++)
                {
                    field[i, j] = 0;
                    isOpen[i, j] = false;
                }
            }

            Random rand = new Random();
            // srand(time(0));

            //int numMines = rand() % 5 + 8;
            int avgSize = (SIZE_X + SIZE_Y) / 2;
            int numMines = rand.Next(1, 2);// avgSize * 3);

            for (int i = 1; i <= numMines; i++)
            {
                x = rand.Next(SIZE_X);
                y = rand.Next(SIZE_Y);
                field[x, y] = -1;
            }

            //Fill in the fild with numbers
            for (int i = 0; i < SIZE_X; i++)
            {
                for (int j = 0; j < SIZE_Y; j++)
                {
                    if (field[i, j] != -1)
                    {
                        k = 0;
                        if (mine(i - 1, j - 1))
                            k++;
                        if (mine(i - 1, j))
                            k++;
                        if (mine(i - 1, j + 1))
                            k++;
                        if (mine(i, j - 1))
                            k++;
                        if (mine(i, j + 1))
                            k++;
                        if (mine(i + 1, j - 1))
                            k++;
                        if (mine(i + 1, j))
                            k++;
                        if (mine(i + 1, j + 1))
                            k++;

                        field[i, j] = k;
                    }

                }
            }
        }

        // =================================================

        //Opens all the mines in the event of a loss
        public void openAllMines()
        {

            for (int i = 0; i < SIZE_X; i++)
            {
                for (int j = 0; j < SIZE_Y; j++)
                {
                    if (field[i, j] == -1)
                        isOpen[i, j] = true;
                }
            }
        }

        public void openAll()
        {
            for (int i = 0; i < SIZE_X; i++)
            {
                for (int j = 0; j < SIZE_Y; j++)
                {
                    isOpen[i, j] = true;
                }
            }
        }

        public void openButton(int i, int j)
        {

            if (i >= 0 && i < SIZE_X)
            {
                if (j >= 0 && j < SIZE_Y)
                {
                    //Перевіримо, чи не було відкрито поле раніше
                    //check if the field was previously open
                    if (!isOpen[i, j] && field[i, j] != -1)
                    {
                        isOpen[i, j] = true;

                        if (field[i, j] == 0)
                        {
                            openButton(i - 1, j - 1);
                            openButton(i - 1, j);
                            openButton(i - 1, j + 1);
                            openButton(i, j - 1);
                            openButton(i, j + 1);
                            openButton(i + 1, j - 1);
                            openButton(i + 1, j);
                            openButton(i + 1, j + 1);
                        }
                        //If not empty (!=0) open only empty (=0) neighbors
                        else
                        {
                            if (empty(i - 1, j - 1))
                                openButton(i - 1, j - 1);
                            if (empty(i - 1, j))
                                openButton(i - 1, j);
                            if (empty(i - 1, j + 1))
                                openButton(i - 1, j + 1);
                            if (empty(i, j - 1))
                                openButton(i, j - 1);
                            if (empty(i, j + 1))
                                openButton(i, j + 1);
                            if (empty(i + 1, j - 1))
                                openButton(i + 1, j - 1);
                            if (empty(i + 1, j))
                                openButton(i + 1, j);
                            if (empty(i + 1, j + 1))
                                openButton(i + 1, j + 1);
                        }

                    }
                }
            }
        }

        public bool checkWin()
        {
            for (int i = 0; i < SIZE_X; i++)
                for (int j = 0; j < SIZE_Y; j++)
                    if ((field[i, j] != -1) && (!isOpen[i, j]))
                        return false;

            return true;
        }

        public void setSize(int newSizeX, int newSizeY)
        {
            SIZE_X = newSizeX;
            SIZE_Y = newSizeY;
            initArrays();
        }
        public int getSize()
        {
            return SIZE_X * SIZE_Y;
        }

    }
}
