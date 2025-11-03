using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    // Klassen Input läser tangenttryckningar i realtid via Windows API
    class Input
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        // Returnerar true om en tangent trycks ned just nu
        public static bool IsPressed(ConsoleKey key)
        {
            return (GetAsyncKeyState((int)key) & 0x8000) != 0;
        }
    }
}
