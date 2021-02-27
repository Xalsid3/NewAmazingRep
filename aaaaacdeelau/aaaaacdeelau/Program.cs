using System;
using System.Collections.Generic;

namespace aaaaacdeelau
{
    class Field
    {
        public void Matr10()
        {
            char[,] Matrx1 = {{'╓','╓','╓','╓','╓','╓','╓','╓','╓','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓','╓','╓','╓','╓','╓','╓','╓','╓','╓'}};
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    Console.Write(Matrx1[i, j].ToString().PadLeft(2));
                }
                Console.WriteLine();
            }
        }
        public void Matr15()
        {
            char[,] Matrx2 = {{'╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓'} };
            for (int i = 0; i < 15; ++i)
            {
                for (int j = 0; j < 15; ++j)
                {
                    Console.Write(Matrx2[i, j].ToString().PadLeft(2));
                }
                Console.WriteLine();
            }
        }
        public void Matr20()
        {
            char[,] Matrx3 = {{'╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','╓'},
                              {'╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓','╓'}};
            for (int i = 0; i < 20; ++i)
            {
                for (int j = 0; j < 20; ++j)
                {
                    Console.Write(Matrx3[i, j].ToString().PadLeft(2));
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        public static int fx, fy, x, y, t;
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(41, 23);
            Console.SetWindowSize(41, 23);
        chek:
            Field field = new Field();
            Console.WriteLine("Difficult:\n1 - Easy\n2 - Normal\n3 - Hard");
            int dif = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (dif)
            {
                case 1:
                    field.Matr10();
                    dif = 10;
                    break;
                case 2:
                    field.Matr15();
                    dif = 15;
                    break;
                case 3:
                    field.Matr20();
                    dif = 20;
                    break;
                default:
                    goto chek;
            }

            x = 1; y = 1;
            Player(dif);
            Console.ReadKey();
        }

        static void Food(int dif)
        {
            Random random = new Random();
            do
            {
                fx = random.Next(3, (dif - 2) * 2);
                fy = random.Next(3, dif - 1);
            } while (fx % 2 == 0);
            List<char> food = new List<char>() { '@' };
            Console.SetCursorPosition(fx, fy);
            foreach (char i in food)
            {
                Console.Write(i);
            }
        }
        public static int score = 0;
        static void Player(int dif)
        {
            Console.SetCursorPosition(3, dif + 1);
            Console.WriteLine("Score: 0");

            Food(dif);
            Console.SetCursorPosition(3, 3);
            Console.CursorVisible = false;
            var listX = new List<int>();
            var listY = new List<int>();
            x = 3;
            y = 3;
            bool upA = false;
            bool downA = false;
            bool rightA = false;
            bool leftA = false;

            ConsoleKeyInfo k;

            do
            {
                k = Console.ReadKey(true);

                if (k.Key == ConsoleKey.UpArrow && downA == false)
                {

                    upA = true;
                    downA = false;
                    rightA = false;
                    leftA = false;
                    do
                    {

                        if (listX.Count > score)
                        {
                            for (int i = 0; i <= listX.Count - score; ++i)
                            {
                                Console.SetCursorPosition(listX[i], listY[i]);
                                Console.Write(' ');
                                listX.RemoveAt(i);
                                listY.RemoveAt(i);
                            }
                        }

                        if (y - 1 != 0)
                        {
                            y--;
                            Console.SetCursorPosition(x, y);
                            Console.Write('▄');
                            listX.Add(x);
                            listY.Add(y);

                            for (int i = 0; i <= score; ++i)
                            {
                                if (fx == listX[i] && fy == listY[i])
                                {
                                    Food(dif);
                                    ++score;
                                    Console.SetCursorPosition(listX[i], listY[i]);
                                    Console.Write('▄');
                                    Console.SetCursorPosition(3, dif + 1);
                                    Console.WriteLine("Score: " + score);
                                    break;
                                }
                            }

                            System.Threading.Thread.Sleep(3000 / dif);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("U lose Idiot!");
                            System.Threading.Thread.Sleep(2000);
                            Environment.Exit(0);
                        }
                        t = (listX.Count) - 1;
                        if (listX.Count > 4)
                        {
                            for (int i = 0; i < t; ++i)
                            {
                                if (listX[t] == listX[i] && listY[t] == listY[i])
                                {
                                    Console.Clear();
                                    Console.WriteLine("U lose Idiot!");
                                    System.Threading.Thread.Sleep(2000);
                                    Environment.Exit(0);
                                }
                            }
                        }
                    } while (!Console.KeyAvailable);

                }//up
                else if (k.Key == ConsoleKey.DownArrow && upA == false)
                {

                    upA = false;
                    downA = true;
                    rightA = false;
                    leftA = false;
                    do
                    {
                        if (listX.Count > score)
                        {
                            for (int i = 0; i <= listX.Count - score; ++i)
                            {
                                Console.SetCursorPosition(listX[i], listY[i]);
                                Console.Write(' ');
                                listX.RemoveAt(i);
                                listY.RemoveAt(i);
                            }
                        }

                        if (y + 1 != dif - 1)
                        {
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write('▄');
                            listX.Add(x);
                            listY.Add(y);

                            for (int i = 0; i <= score; ++i)
                            {
                                if (fx == listX[i] && fy == listY[i])
                                {
                                    Food(dif);
                                    ++score;
                                    Console.SetCursorPosition(listX[i], listY[i]);
                                    Console.Write('▄');
                                    Console.SetCursorPosition(3, dif + 1);
                                    Console.WriteLine("Score: " + score);
                                    break;
                                }
                            }
                            System.Threading.Thread.Sleep(3000 / dif);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("U lose Idiot!");
                            System.Threading.Thread.Sleep(2000);
                            Environment.Exit(0);
                        }
                        t = (listX.Count) - 1;
                        if (listX.Count > 4)
                        {
                            for (int i = 0; i < t; ++i)
                            {
                                if (listX[t] == listX[i] && listY[t] == listY[i])
                                {
                                    Console.Clear();
                                    Console.WriteLine("U lose Idiot!");
                                    System.Threading.Thread.Sleep(2000);
                                    Environment.Exit(0);
                                }
                            }
                        }
                    } while (!Console.KeyAvailable);
                }

                else if (k.Key == ConsoleKey.LeftArrow && rightA == false)
                {

                    upA = false;
                    downA = false;
                    rightA = false;
                    leftA = true;
                    do
                    {

                        if (listX.Count > score)
                        {
                            for (int i = 0; i <= listX.Count - score; ++i)
                            {
                                Console.SetCursorPosition(listX[i], listY[i]);
                                Console.Write(' ');
                                listX.RemoveAt(i);
                                listY.RemoveAt(i);
                            }
                        }
                        if (x - 2 != 1)
                        {
                            x -= 2;
                            Console.SetCursorPosition(x, y);
                            Console.Write('▄');
                            listX.Add(x);
                            listY.Add(y);

                            for (int i = 0; i <= score; ++i)
                            {
                                if (fx == listX[i] && fy == listY[i])
                                {
                                    Food(dif);
                                    ++score;
                                    Console.SetCursorPosition(listX[i], listY[i]);
                                    Console.Write('▄');
                                    Console.SetCursorPosition(3, dif + 1);
                                    Console.WriteLine("Score: " + score);
                                    break;
                                }
                            }
                            System.Threading.Thread.Sleep(3000 / dif);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("U lose Idiot!");
                            System.Threading.Thread.Sleep(2000);
                            Environment.Exit(0);
                        }
                        t = (listX.Count) - 1;
                        if (listX.Count > 4)
                        {
                            for (int i = 0; i < t; ++i)
                            {
                                if (listX[t] == listX[i] && listY[t] == listY[i])
                                {
                                    Console.Clear();
                                    Console.WriteLine("U lose Idiot!");
                                    System.Threading.Thread.Sleep(2000);
                                    Environment.Exit(0);
                                }
                            }
                        }
                    } while (!Console.KeyAvailable);
                }


                else if (k.Key == ConsoleKey.RightArrow && leftA == false)
                {

                    upA = false;
                    downA = false;
                    rightA = true;
                    leftA = false;
                    do
                    {
                        if (listX.Count > score)
                        {
                            for (int i = 0; i <= listX.Count - score; ++i)
                            {
                                Console.SetCursorPosition(listX[i], listY[i]);
                                Console.Write(' ');
                                listX.RemoveAt(i);
                                listY.RemoveAt(i);
                            }
                        }


                        if (x != 2 * dif - 3)
                        {
                            x += 2;
                            Console.SetCursorPosition(x, y);
                            Console.Write('▄');
                            listX.Add(x);
                            listY.Add(y);

                            for (int i = 0; i <= score; ++i)
                            {
                                if (fx == listX[i] && fy == listY[i])
                                {
                                    Food(dif);
                                    ++score;
                                    Console.SetCursorPosition(listX[i], listY[i]);
                                    Console.Write('▄');
                                    Console.SetCursorPosition(3, dif + 1);
                                    Console.WriteLine("Score: " + score);
                                    break;
                                }
                            }
                            System.Threading.Thread.Sleep(3000 / dif);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("U lose Idiot!");
                            System.Threading.Thread.Sleep(2000);
                            Environment.Exit(0);
                        }
                        t = (listX.Count) - 1;

                        if (listX.Count > 4)
                        {
                            for (int i = 0; i < t; ++i)
                            {
                                if (listX[t] == listX[i] && listY[t] == listY[i])
                                {
                                    Console.Clear();
                                    Console.WriteLine("U lose Idiot!");
                                    System.Threading.Thread.Sleep(2000);
                                    Environment.Exit(0);
                                }
                            }
                        }

                    } while (!Console.KeyAvailable);
                }
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}