using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace TetrisGame
{
    internal class Tetris
    {
        public const int Width = 10;
        public const int Height = 24;

        List<int>[,] gameTable = new List<int>[10,20];
        int blockSize = 20;


        public void FirstDrawTable(Panel form) {

            float width = Width * blockSize;
            float height = Height * blockSize;

            float x1 = 0;
            float y1 = 0;

            Graphics g;

            try
            {
                g = form.CreateGraphics();
            }
            catch
            {
                return;
            }

            //SolidBrush myBrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black, 1);    

            for (int i = 0; i < gameTable.GetLength(0); i++)
            {
                for (int j = 0; j < gameTable.GetLength(1); j++)
                {
                    g.DrawRectangle(myPen, x1+i*blockSize, y1+j*blockSize, blockSize, blockSize);
                }
            };
        }

        private int[,] GetBlockArray(int block, int direction)
        {
            switch (block)
            {
                case 0:
                    // ##
                    // ##
                    switch (direction)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                            return new int[2, 2] { { 1, 1 }, { 1, 1 } };
                    }
                    break;
                case 1:
                    // ####
                    switch (direction)
                    {
                        case 0:
                        case 2:
                            return new int[4, 4] { { 0, 0, 0, 0 }, { 1, 1, 1, 1 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
                        case 1:
                        case 3:
                            return new int[4, 4] { { 0, 0, 1, 0 }, { 0, 0, 1, 0 }, { 0, 0, 1, 0 }, { 0, 0, 1, 0 } };
                    }
                    break;
                case 2:
                    //  ##
                    // ##
                    switch (direction)
                    {
                        case 0:
                        case 2:
                            return new int[3, 3] { { 0, 0, 0 }, { 0, 1, 1 }, { 1, 1, 0 } };
                        case 1:
                        case 3:
                            return new int[3, 3] { { 0, 1, 0 }, { 0, 1, 1 }, { 0, 0, 1 } };
                    }
                    break;
                case 3:
                    // ##
                    //  ##
                    switch (direction)
                    {
                        case 0:
                        case 2:
                            return new int[3, 3] { { 0, 0, 0 }, { 1, 1, 0 }, { 0, 1, 1 } };
                        case 1:
                        case 3:
                            return new int[3, 3] { { 0, 0, 1 }, { 0, 1, 1 }, { 0, 1, 0 } };
                    }
                    break;
                case 4:
                    // ###
                    // #
                    switch (direction)
                    {
                        case 0:
                            return new int[3, 3] { { 0, 0, 0 }, { 1, 1, 1 }, { 1, 0, 0 } };
                        case 1:
                            return new int[3, 3] { { 0, 1, 0 }, { 0, 1, 0 }, { 0, 1, 1 } };
                        case 2:
                            return new int[3, 3] { { 0, 0, 1 }, { 1, 1, 1 }, { 0, 0, 0 } };
                        case 3:
                            return new int[3, 3] { { 1, 1, 0 }, { 0, 1, 0 }, { 0, 1, 0 } };
                    }
                    break;
                case 5:
                    // ###
                    //   #
                    switch (direction)
                    {
                        case 0:
                            return new int[3, 3] { { 0, 0, 0 }, { 1, 1, 1 }, { 0, 0, 1 } };
                        case 1:
                            return new int[3, 3] { { 0, 1, 1 }, { 0, 1, 0 }, { 0, 1, 0 } };
                        case 2:
                            return new int[3, 3] { { 1, 0, 0 }, { 1, 1, 1 }, { 0, 0, 0 } };
                        case 3:
                            return new int[3, 3] { { 0, 0, 1 }, { 0, 0, 1 }, { 0, 1, 1 } };
                    }
                    break;
                case 6:
                    // ###
                    //  #
                    switch (direction)
                    {
                        case 0:
                            return new int[3, 3] { { 0, 0, 0 }, { 1, 1, 1 }, { 0, 1, 0 } };
                        case 1:
                            return new int[3, 3] { { 0, 1, 0 }, { 0, 1, 1 }, { 0, 1, 0 } };
                        case 2:
                            return new int[3, 3] { { 0, 1, 0 }, { 1, 1, 1 }, { 0, 0, 0 } };
                        case 3:
                            return new int[3, 3] { { 0, 1, 0 }, { 1, 1, 0 }, { 0, 1, 0 } };
                    }
                    break;
            }

            return null;
        }


    }
}
