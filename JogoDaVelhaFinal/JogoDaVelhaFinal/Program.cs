using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelhaFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            String jog1;
            String jog2;
            char p1 = '1', p2 = '2', p3 = '3', p4 = '4', p5 = '5', p6 = '6', p7 = '7', p8 = '8', p9 = '9';
            char x1 = 'x', x2 = 'x', x3 = 'x', x4 = 'x', x5 = 'x', x6 = 'x', x7 = 'x', x8 = 'x', x9 = 'x';
            char o1 = 'o', o2 = 'o', o3 = 'o', o4 = 'o', o5 = 'o', o6 = 'o', o7 = 'o', o8 = 'o', o9 = 'o';
            int pos1, pos2;

            Console.WriteLine("Insira o nome do jogador 1: ");
            jog1 = Console.ReadLine();
            Console.WriteLine("Insira o nome do jogador 2: ");
            jog2 = Console.ReadLine();



            Console.WriteLine("       |       |");
            Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
            Console.WriteLine("-------|-------|-------");
            Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
            Console.WriteLine("-------|-------|-------");
            Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
            Console.WriteLine("       |       |");

            // início: jogador 1








            while (

               (
               !(
               (((p1 != p2) && (p1 != '1' && p2 != '2')) || ((p1 != p3) && (p1 != '1' && p3 != '3'))
               || ((p2 != p3) && (p2 != '2' && p3 != '3'))) && (((p4 != p5) && (p4 != '4' && p5 != '5')) ||
               ((p4 != p6) && (p4 != '4' && p6 != '6')) || ((p5 != p6) && (p5 != '5' && p6 != '6'))) &&
               (((p7 != p8) && (p7 != '7' && p8 != '8')) || ((p7 != p9) && (p7 != '7' && p9 != '9')) ||
               ((p8 != p9) && (p8 != '8' && p9 != '9'))) &&
               (((p1 != p4) && (p1 != '1' && p4 != '4')) || ((p1 != p7) && (p1 != '1' && p7 != '7')) ||
               ((p4 != p7) && (p4 != '4' && p7 != '7'))) &&
               (((p2 != p5) && (p2 != '2' && p5 != '5')) || ((p2 != p8) && (p2 != '2' && p8 != '8')) ||
               ((p5 != p8) && (p5 != '5' && p8 != '8'))) &&
               (((p3 != p6) && (p3 != '3' && p6 != '6')) || ((p3 != p9) && (p3 != '3' && p9 != '9')) ||
               ((p6 != p9) && (p6 != '6' && p9 != '9'))) &&
               (((p1 != p5) && (p1 != '1' && p5 != '5')) || ((p1 != p9) && (p1 != '1' && p9 != '9')) ||
               ((p5 != p9) && (p5 != '5' && p9 != '9'))) &&
               (((p3 != p5) && (p3 != '3' && p5 != '5')) || ((p3 != p7) && (p3 != '3' && p7 != '7')) ||
               ((p5 != p7) && (p5 != '5' && p7 != '7')))
               )
               )


                 &&

                    (!((p1 == p2 && p2 == p3 && p1 == 'o') || (p4 == p5 && p5 == p6 && p4 == 'o') || (p7 == p8 && p8 == p9 && p7 == 'o') || (p1 == p4 && p4 == p7 && p4 == 'o') || (p2 == p5 && p5 == p8 && p8 == 'o')
                || (p3 == p6 && p6 == p9 && p9 == 'o') || (p1 == p5 && p5 == p9 && p9 == 'o') || (p3 == p5 && p5 == p7 && p7 == 'o') || (p1 == p2 && p2 == p3 && p1 == 'x') || (p4 == p5 && p5 == p6 && p4 == 'x') || (p7 == p8 && p8 == p9 && p7 == 'x')
                || (p1 == p4 && p4 == p7 && p4 == 'x') || (p2 == p5 && p5 == p8 && p8 == 'x') || (p3 == p6 && p6 == p9 && p9 == 'x') || (p1 == p5 && p5 == p9 && p9 == 'x') || (p3 == p5 && p5 == p7 && p7 == 'x')))

                )
            {



                Console.WriteLine(jog1 + ", digite o número da posição para preencher com X: ");
                pos1 = Convert.ToInt16(Console.ReadLine());


                while ((pos1 != 1 && pos1 != 2 && pos1 != 3 && pos1 != 4 && pos1 != 5 && pos1 != 6 && pos1 != 7 && pos1 != 8 && pos1 != 9) || ((pos1 == 1 && (p1 == x1 || p1 == o1)) || (pos1 == 2 && (p2 == x2 || p2 == o2)) || (pos1 == 3 && (p3 == x3 || p3 == o3)) || (pos1 == 4 && (p4 == x4 || p4 == o4)) || (pos1 == 5 && (p5 == x5 || p5 == o5)) || (pos1 == 6 && (p6 == x6 || p6 == o6)) || (pos1 == 7 && (p7 == x7 || p7 == o7)) || (pos1 == 8 && (p8 == x8 || p8 == o8)) || (pos1 == 9 && (p9 == x9 || p9 == o9))))
                {
                    Console.WriteLine("Digite uma opção válida!!");
                    Console.WriteLine(jog1 + ", digite o número da posição para preencher com X: ");
                    pos1 = Convert.ToInt16(Console.ReadLine());
                }




                if (pos1 == 1)
                {
                    p1 = x1;
                    Console.WriteLine("       |       |");
                    Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
                    Console.WriteLine("-------|-------|-------");
                    Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
                    Console.WriteLine("-------|-------|-------");
                    Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
                    Console.WriteLine("       |       |");


                }
                else if (pos1 == 2)
                {
                    p2 = x2;
                    Console.WriteLine("       |       |");
                    Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
                    Console.WriteLine("-------|-------|-------");
                    Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
                    Console.WriteLine("-------|-------|-------");
                    Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
                    Console.WriteLine("       |       |");
                }
                else if (pos1 == 3)
                {
                    p3 = x3;
                    Console.WriteLine("       |       |");
                    Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
                    Console.WriteLine("-------|-------|-------");
                    Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
                    Console.WriteLine("-------|-------|-------");
                    Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
                    Console.WriteLine("       |       |");
                }
                else if (pos1 == 4)
                {
                    p4 = x4;
                    Console.WriteLine("       |       |");
                    Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
                    Console.WriteLine("-------|-------|-------");
                    Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
                    Console.WriteLine("-------|-------|-------");
                    Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
                    Console.WriteLine("       |       |");
                }
                else if (pos1 == 5)
                {
                    p5 = x5;
                    Console.WriteLine("       |       |");
                    Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
                    Console.WriteLine("-------|-------|-------");
                    Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
                    Console.WriteLine("-------|-------|-------");
                    Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
                    Console.WriteLine("       |       |");
                }
                else if (pos1 == 6)
                {
                    p6 = x6;
                    Console.WriteLine("       |       |");
                    Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
                    Console.WriteLine("-------|-------|-------");
                    Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
                    Console.WriteLine("-------|-------|-------");
                    Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
                    Console.WriteLine("       |       |");
                }
                else if (pos1 == 7)
                {
                    p7 = x7;
                    Console.WriteLine("       |       |");
                    Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
                    Console.WriteLine("-------|-------|-------");
                    Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
                    Console.WriteLine("-------|-------|-------");
                    Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
                    Console.WriteLine("       |       |");
                }
                else if (pos1 == 8)
                {
                    p8 = x8;
                    Console.WriteLine("       |       |");
                    Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
                    Console.WriteLine("-------|-------|-------");
                    Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
                    Console.WriteLine("-------|-------|-------");
                    Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
                    Console.WriteLine("       |       |");
                }
                else if (pos1 == 9)
                {
                    p9 = x9;
                    Console.WriteLine("       |       |");
                    Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
                    Console.WriteLine("-------|-------|-------");
                    Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
                    Console.WriteLine("-------|-------|-------");
                    Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
                    Console.WriteLine("       |       |");
                }

                if (
               (
               (((p1 != p2) && (p1 != '1' && p2 != '2')) || ((p1 != p3) && (p1 != '1' && p3 != '3'))
               || ((p2 != p3) && (p2 != '2' && p3 != '3'))) && (((p4 != p5) && (p4 != '4' && p5 != '5')) ||
               ((p4 != p6) && (p4 != '4' && p6 != '6')) || ((p5 != p6) && (p5 != '5' && p6 != '6'))) &&
               (((p7 != p8) && (p7 != '7' && p8 != '8')) || ((p7 != p9) && (p7 != '7' && p9 != '9')) ||
               ((p8 != p9) && (p8 != '8' && p9 != '9'))) &&
               (((p1 != p4) && (p1 != '1' && p4 != '4')) || ((p1 != p7) && (p1 != '1' && p7 != '7')) ||
               ((p4 != p7) && (p4 != '4' && p7 != '7'))) &&
               (((p2 != p5) && (p2 != '2' && p5 != '5')) || ((p2 != p8) && (p2 != '2' && p8 != '8')) ||
               ((p5 != p8) && (p5 != '5' && p8 != '8'))) &&
               (((p3 != p6) && (p3 != '3' && p6 != '6')) || ((p3 != p9) && (p3 != '3' && p9 != '9')) ||
               ((p6 != p9) && (p6 != '6' && p9 != '9'))) &&
               (((p1 != p5) && (p1 != '1' && p5 != '5')) || ((p1 != p9) && (p1 != '1' && p9 != '9')) ||
               ((p5 != p9) && (p5 != '5' && p9 != '9'))) &&
               (((p3 != p5) && (p3 != '3' && p5 != '5')) || ((p3 != p7) && (p3 != '3' && p7 != '7')) ||
               ((p5 != p7) && (p5 != '5' && p7 != '7')))
               )
               ) { Console.WriteLine("A velha venceu!"); };

                // jogador 2

                if (!((p1 == p2 && p2 == p3 && p1 == 'x') || (p4 == p5 && p5 == p6 && p4 == 'x') || (p7 == p8 && p8 == p9 && p7 == 'x') || (p1 == p4 && p4 == p7 && p4 == 'x') || (p2 == p5 && p5 == p8 && p8 == 'x') || (p3 == p6 && p6 == p9 && p9 == 'x') || (p1 == p5 && p5 == p9 && p9 == 'x') || (p3 == p5 && p5 == p7 && p7 == 'x')))
                {




                    Console.WriteLine(jog2 + ", digite o número da posição para preencher com O: ");
                    pos2 = Convert.ToInt16(Console.ReadLine());

                    while ((pos2 != 1 && pos2 != 2 && pos2 != 3 && pos2 != 4 && pos2 != 5 && pos2 != 6 && pos2 != 7 && pos2 != 8 && pos2 != 9) || ((pos2 == 1 && (p1 == x1 || p1 == o1)) || (pos2 == 2 && (p2 == x2 || p2 == o2)) || (pos2 == 3 && (p3 == x3 || p3 == o3)) || (pos2 == 4 && (p4 == x4 || p4 == o4)) || (pos2 == 5 && (p5 == x5 || p5 == o5)) || (pos2 == 6 && (p6 == x6 || p6 == o6)) || (pos2 == 7 && (p7 == x7 || p7 == o7)) || (pos2 == 8 && (p8 == x8 || p8 == o8)) || (pos2 == 9 && (p9 == x9 || p9 == o9))))
                    {

                        Console.WriteLine("Digite uma opção válida!!");
                        Console.WriteLine(jog2 + ", digite o número da posição para preencher com O: ");
                        pos2 = Convert.ToInt16(Console.ReadLine());
                    }


                    if (pos2 == 1)


                    {
                        p1 = o1;
                        Console.WriteLine("       |       |");
                        Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
                        Console.WriteLine("-------|-------|-------");
                        Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
                        Console.WriteLine("-------|-------|-------");
                        Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
                        Console.WriteLine("       |       |");
                    }
                    else if (pos2 == 2)
                    {
                        p2 = o2;
                        Console.WriteLine("       |       |");
                        Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
                        Console.WriteLine("-------|-------|-------");
                        Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
                        Console.WriteLine("-------|-------|-------");
                        Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
                        Console.WriteLine("       |       |");
                    }
                    else if (pos2 == 3)
                    {
                        p3 = o3;
                        Console.WriteLine("       |       |");
                        Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
                        Console.WriteLine("-------|-------|-------");
                        Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
                        Console.WriteLine("-------|-------|-------");
                        Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
                        Console.WriteLine("       |       |");
                    }
                    else if (pos2 == 4)
                    {
                        p4 = o4;
                        Console.WriteLine("       |       |");
                        Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
                        Console.WriteLine("-------|-------|-------");
                        Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
                        Console.WriteLine("-------|-------|-------");
                        Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
                        Console.WriteLine("       |       |");
                    }
                    else if (pos2 == 5)
                    {
                        p5 = o5;
                        Console.WriteLine("       |       |");
                        Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
                        Console.WriteLine("-------|-------|-------");
                        Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
                        Console.WriteLine("-------|-------|-------");
                        Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
                        Console.WriteLine("       |       |");
                    }
                    else if (pos2 == 6)
                    {
                        p6 = o6;
                        Console.WriteLine("       |       |");
                        Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
                        Console.WriteLine("-------|-------|-------");
                        Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
                        Console.WriteLine("-------|-------|-------");
                        Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
                        Console.WriteLine("       |       |");
                    }
                    else if (pos2 == 7)
                    {
                        p7 = o7;
                        Console.WriteLine("       |       |");
                        Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
                        Console.WriteLine("-------|-------|-------");
                        Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
                        Console.WriteLine("-------|-------|-------");
                        Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
                        Console.WriteLine("       |       |");
                    }
                    else if (pos2 == 8)
                    {
                        p8 = o8;
                        Console.WriteLine("       |       |");
                        Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
                        Console.WriteLine("-------|-------|-------");
                        Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
                        Console.WriteLine("-------|-------|-------");
                        Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
                        Console.WriteLine("       |       |");
                    }
                    else if (pos2 == 9)
                    {
                        p9 = o9;
                        Console.WriteLine("       |       |");
                        Console.WriteLine("   " + p1 + "   |   " + p2 + "   |   " + p3);
                        Console.WriteLine("-------|-------|-------");
                        Console.WriteLine("   " + p4 + "   |   " + p5 + "   |   " + p6);
                        Console.WriteLine("-------|-------|-------");
                        Console.WriteLine("   " + p7 + "   |   " + p8 + "   |   " + p9);
                        Console.WriteLine("       |       |");
                    }

                    if ((p1 == p2 && p2 == p3 && p1 == 'o') || (p4 == p5 && p5 == p6 && p4 == 'o') || (p7 == p8 && p8 == p9 && p7 == 'o') || (p1 == p4 && p4 == p7 && p4 == 'o') || (p2 == p5 && p5 == p8 && p8 == 'o') || (p3 == p6 && p6 == p9 && p9 == 'o') || (p1 == p5 && p5 == p9 && p9 == 'o') || (p3 == p5 && p5 == p7 && p7 == 'o'))
                    {
                        Console.WriteLine(jog2 + " venceu!!");
                    }
                }


                else if (((p1 == p2 && p2 == p3 && p1 == 'x') || (p4 == p5 && p5 == p6 && p4 == 'x') || (p7 == p8 && p8 == p9 && p7 == 'x') || (p1 == p4 && p4 == p7 && p4 == 'x') || (p2 == p5 && p5 == p8 && p8 == 'x') || (p3 == p6 && p6 == p9 && p9 == 'x') || (p1 == p5 && p5 == p9 && p9 == 'x') || (p3 == p5 && p5 == p7 && p7 == 'x')))
                {
                    Console.WriteLine(jog1 + " venceu!!");
                }
                else if (
               (
               (((p1 != p2) && (p1 != '1' && p2 != '2')) || ((p1 != p3) && (p1 != '1' && p3 != '3'))
               || ((p2 != p3) && (p2 != '2' && p3 != '3'))) && (((p4 != p5) && (p4 != '4' && p5 != '5')) ||
               ((p4 != p6) && (p4 != '4' && p6 != '6')) || ((p5 != p6) && (p5 != '5' && p6 != '6'))) &&
               (((p7 != p8) && (p7 != '7' && p8 != '8')) || ((p7 != p9) && (p7 != '7' && p9 != '9')) ||
               ((p8 != p9) && (p8 != '8' && p9 != '9'))) &&
               (((p1 != p4) && (p1 != '1' && p4 != '4')) || ((p1 != p7) && (p1 != '1' && p7 != '7')) ||
               ((p4 != p7) && (p4 != '4' && p7 != '7'))) &&
               (((p2 != p5) && (p2 != '2' && p5 != '5')) || ((p2 != p8) && (p2 != '2' && p8 != '8')) ||
               ((p5 != p8) && (p5 != '5' && p8 != '8'))) &&
               (((p3 != p6) && (p3 != '3' && p6 != '6')) || ((p3 != p9) && (p3 != '3' && p9 != '9')) ||
               ((p6 != p9) && (p6 != '6' && p9 != '9'))) &&
               (((p1 != p5) && (p1 != '1' && p5 != '5')) || ((p1 != p9) && (p1 != '1' && p9 != '9')) ||
               ((p5 != p9) && (p5 != '5' && p9 != '9'))) &&
               (((p3 != p5) && (p3 != '3' && p5 != '5')) || ((p3 != p7) && (p3 != '3' && p7 != '7')) ||
               ((p5 != p7) && (p5 != '5' && p7 != '7')))
               )) { Console.WriteLine("A velha venceu!"); };

            }

            if (((p1 != p2) || (p1 != p3) || (p3 != p2)) && ((p4 != p5) || (p4 != p6) || (p5 != p6)) && ((p7 != p8) || (p7 != p9) || (p8 != p9))
                && ((p1 != p4) || (p1 != p7) || (p4 != p7)) && ((p2 != p5) || (p2 != p8) || (p5 != p8)) && ((p3 != p6) || (p3 != p9) || (p6 != p9)) && ((p1 != p5) || (p1 != p9) || (p5 != p9)) && ((p3 != p5) || (p3 != p5) || (p5 != p9)))


                Console.WriteLine("A Velha venceu!!");






        }
    }
}
