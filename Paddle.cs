using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Paddle
    {
      public int x;
      public int y;
      public int size;
       public Paddle(int startX,int startY,int paddleSize)
        {
            x = startX;
            y = startY;
            size = paddleSize;
        }
        public void Move(int yAmount)
        {
            y -= yAmount;

            // Se till att paddeln inte går utanför toppen
            if (y < 0)
                y = 0;

            // Se till att paddeln inte går utanför botten
            if (y + size > Console.WindowHeight)
                y = Console.WindowHeight - size;
        }
        public void Draw()
          
        {
            for (int i = 0; i < size; i++)
            {
                int drawY = y + i;
                if (drawY >= 0 && drawY < Console.WindowHeight)
                {
                    Console.SetCursorPosition(x, y + i);
                }

                Console.Write("|");
            } 
        }
    
    }
}
