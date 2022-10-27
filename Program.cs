using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pianino1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здарова.\n Это пианино.  \n Выбери,что будем делать. :\n 1. Пианино  \n 2. Выход с приложения ");
            int choise = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (choise == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Кратце говоря,здесь 12 букв на которых имеется звук :\n  A W S E D F T G Y H U J (#0_0) \n Увиличение октавы , вам придется нажать на  F5, чтобы понизить - F6  ");
                    Octave();
                    Console.ReadKey();

                }
                else if (choise == 2)
                {
                    Console.WriteLine("Выйти?");
                    break;
                }
                else
                {
                    Console.WriteLine("есть только два действия,дурак?!");
                    Console.WriteLine("Выбери правилное действие:\n 1. Начать играть  \n 2. 2 = выход");
                    choise = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }

            }
            Console.ReadKey();
        }
        static void Octave()
        {
            int[,] NoteFreq = new[,] {{ 65, 69, 73, 78, 82, 87, 93, 98, 104, 110, 116, 123 },
                                       { 131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 246 },
                                       { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 },
                                       { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 },
                                       { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 },
                                       { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 },
                                       { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 } };

            int Octave = 1;

            ConsoleKey keyCheck;

            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyCheck = keyInfo.Key;
                switch (keyCheck)
                {
                    case ConsoleKey.A:
                        Console.Beep(NoteFreq[Octave, 0], 300);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(NoteFreq[Octave, 1], 300);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(NoteFreq[Octave, 2], 300);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(NoteFreq[Octave, 3], 300);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(NoteFreq[Octave, 4], 300);
                        break;
                    case ConsoleKey.F:
                        Console.Beep(NoteFreq[Octave, 5], 300);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(NoteFreq[Octave, 6], 300);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(NoteFreq[Octave, 7], 300);
                        break;
                }
            } while(keyCheck != ConsoleKey.Escape);
        }
    }
}
