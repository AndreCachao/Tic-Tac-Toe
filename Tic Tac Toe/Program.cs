using System;

namespace Tic_Tac_Toe
{
    internal class Program
    {
        static string a = "1", b = "2", c = "3", d = "4", e = "5", f = "6", g = "7", h = "8", i = "9";
        static void Main(string[] args)
        {
            int[,] win = new int[,] {{1,2,3},{4,5,6},{7,8,9},{1,4,7},{2,5,8},{3,6,9},{1,5,9},{3,5,7}};
            int[] player1 = new int[5];
            int[] player2 = new int[5];
            int vez = 1;
            int index1 = 0;
            int index2 = 0;
            int jogadas = 0;

            while (true)
            {
                if (vez == 1)
                {
                    Console.WriteLine("{0}|{1}|{2}\n" + "-----\n" + "{3}|{4}|{5}\n" + "-----\n" + "{6}|{7}|{8}", a, b, c, d, e, f, g, h, i);
                    Console.WriteLine("Jogador 1: ");
                    int jogada = int.Parse(Console.ReadLine());
                    if (jogada >= 1 && jogada <= 9)
                    {
                        if (SamePlay(player2, jogada))
                        {
                            Console.WriteLine("O adversario já vez essa jogada");
                        }
                        else
                        {
                            jogadass(jogada, vez);
                            player1[index1] = jogada;
                            if (Win(win, player1))
                            {
                                Console.WriteLine("Player 1 ganhou!");
                                Console.WriteLine("{0}|{1}|{2}\n" + "-----\n" + "{3}|{4}|{5}\n" + "-----\n" + "{6}|{7}|{8}", a, b, c, d, e, f, g, h, i);
                                break;
                            }
                            index1++;
                            vez = 2;
                        }
                    }
                    else
                        Console.WriteLine("Tem de jogar entre 1 e 10");

                    if (vez == 2)
                    {
                        Console.WriteLine("{0}|{1}|{2}\n" + "-----\n" + "{3}|{4}|{5}\n" + "-----\n" + "{6}|{7}|{8}", a, b, c, d, e, f, g, h, i);
                        Console.WriteLine("Jogador 2: ");
                        jogada = int.Parse(Console.ReadLine());
                        if (jogada >= 1 && jogada <= 9)
                        {
                            if (SamePlay(player1, jogada))
                            {
                                Console.WriteLine("O adversario já vez essa jogada");
                            }
                            else
                            {
                                jogadass(jogada, vez);
                                player2[index2] = jogada;
                                if (Win(win, player2))
                                {
                                    Console.WriteLine("{0}|{1}|{2}\n" + "-----\n" + "{3}|{4}|{5}\n" + "-----\n" + "{6}|{7}|{8}", a, b, c, d, e, f, g, h, i);
                                    Console.WriteLine("Player 2 ganhou!");
                                    break;
                                }
                                index2++;
                                vez = 1;
                            }

                        }
                        else
                            Console.WriteLine("Tem de jogar entre 1 e 10");
                    }

                    if (jogadas == 9)
                    {
                        Console.WriteLine("Jogo Empatado");
                        break;
                    }
                }

            }
        }

        static bool SamePlay(int[] player1, int a)
        {
            for (int i = 0; i < player1.Length; i++)
            {
                if (player1[i] == a)
                {
                    return true;
                }
            }
            return false;
        }

        static bool Win(int[,]won, int[] player)
        {
            int contador;
            for (int i = 0; i < won.GetLength(0); i++)
            {
                contador = 0;
                for (int j = 0; j < won.GetLength(1); j++)
                {
                    for (int k = 0; k < player.GetLength(0); k++)
                    {
                        if (won[i,j] == player[k])
                        {
                            contador++;
                            if (contador == 3)
                            {
                                return true;
                            }

                        }
                    }

                }
            }
            return false;
        }
        static void jogadass(int jogada, int vez)
        {
            string S;
            if (vez == 1)
                S = "X";
            else
                S = "O";

            switch (jogada)
            {
                case 1:
                    a = S;
                    break;
                case 2:
                    b = S;
                    break;
                case 3:
                    c = S;
                    break;
                case 4:
                    d = S;
                    break;
                case 5:
                    e = S;
                    break;
                case 6:
                    f = S;
                    break;
                case 7:
                    g = S;
                    break;
                case 8:
                    h = S;
                    break;
                case 9:
                    i = S;
                    break;
            }
        }
    }
}
