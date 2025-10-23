using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Game
    {
        int width;
        int height;

        Paddle paddle1;
        Paddle paddle2;
        Ball ball;
        public void StartGame()
        {
            // Setup konsol-fönstret
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.CursorVisible = false;

            // Skapa paddlarna
            paddle1 = new Paddle(2, height / 2 - 2, 4);
            paddle2 = new Paddle(width - 3, height / 2 - 2, 4);

            // Skapa bollen
            ball = new Ball(width / 2, height / 2, 1, 1);
        }  

        public bool Run()
        {
            //Töm hela skärmen i början av varje uppdatering.
            Console.Clear();

            // Flytta paddel 1 (Uparrow/Downarrow)
            if (Input.IsPressed(ConsoleKey.UpArrow))
            {
                paddle1.Move(1);
                //Flytta spelare 1 uppåt
            }
            if (Input.IsPressed(ConsoleKey.DownArrow))
            {
                paddle1.Move(-1);
                //Flytta spelare 1 nedåt
            }
            if (Input.IsPressed(ConsoleKey.W))
            {
                paddle2.Move(1);
                //Flytta spelare 2 uppåt
            }
            if (Input.IsPressed(ConsoleKey.S))
            {
                paddle2.Move(-1);
                //Flytta spelare 2 nedåt
            }
            ball.Move();

            ball.CheckCollisions(paddle1, paddle2, width, height);

            paddle1.Draw();
            paddle2.Draw();
            ball.Draw();


            //Return true om spelet ska fortsätta
            return true;

        }
    }
}
