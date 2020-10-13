using System;

namespace ClassTable
{
    class Program
    {
        static readonly TableCreator tableCreator_1 = new TableCreator();
        static readonly TableCreator tableCreator_2 = new TableCreator();
        static public void Main(string[] args)
        {
            Output mOut = new Output();
            int key;
            int dim;

            Console.Clear();
            TextPrinter.MainMenu();
            key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    Console.Clear();
                    int[,] normalTable = tableCreator_1.CreateNormalTable(16);
                    mOut.TableOutput(16, normalTable);
                    break;

                case 2:
                    Console.Clear();
                    TextPrinter.Dimensity();
                    dim = Convert.ToInt32(Console.ReadLine());
                    int[,] randomTable = tableCreator_2.CreateRandomTable(dim);
                    mOut.TableOutput(dim, randomTable);
                    break;

                case 3:
                    Environment.Exit(0);
                    break;


                default:
                    TextPrinter.Default();
                    break;

            }
        }
    }
}

