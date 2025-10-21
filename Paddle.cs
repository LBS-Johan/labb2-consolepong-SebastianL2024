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
            y += yAmount;
        }
        public void Draw()
          
        {
            for (int i = 0; i < size; i++)
            {
                Console.SetCursorPosition(3,10);
                Console.Write("|");
            } 
        }
    
    }
}
