using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{ // Klassen Ball hanterar bollens position, rörelse och kollisioner.
    internal class Ball
    {
        public int x;
        public int y;
        public int xVelocity;// Hur snabbt bollen rör sig i X-led
        public int yVelocity; // Hur snabbt bollen rör sig i Y-led


        public Ball(int startX, int startY, int startXVelocity, int startYVelocity)
        {   // Sätter startposition och hastighet
            x = startX;
            y = startY;
            xVelocity = startXVelocity;
            yVelocity = startYVelocity;
        }

   
        public void Move()  // Sätter startposition och hastighet
        {
            x += xVelocity;
            y += yVelocity;
        }

        public void Draw()   // Ritar ut bollen på konsolen
        {
            Console.SetCursorPosition(x, y);
            Console.Write("O");
        }
        // Kontrollerar om bollen kolliderar med väggar eller paddlar
        public void CheckCollisions(Paddle p1, Paddle p2, int width, int height)
        {
            // Kolla om bollen nuddar toppen eller botten
            if (y <= 0 || y >= height - 1)
                yVelocity *= -1;

            // Kolla kollision med vänster paddel (p1)
            if (x == p1.x + 1 && y >= p1.y && y <= p1.y + p1.size)
                xVelocity *= -1;

            // Kolla kollision med höger paddel (p2)
            if (x == p2.x - 1 && y >= p2.y && y <= p2.y + p2.size)
                xVelocity *= -1;

            // Kolla om bollen går utanför vänster eller höger sida
            if (x <= 0 || x >= width - 1)
            {
                // Återställ till mitten
                x = width / 2;
                y = height / 2;

                // Slumpa ny riktning
                xVelocity *= -1;

            }
        }
    }
}