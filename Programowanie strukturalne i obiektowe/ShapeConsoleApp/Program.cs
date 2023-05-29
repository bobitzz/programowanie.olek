using ShapeConsoleApp.Shapes;
using System;
using System.Collections.Generic;

namespace ShapeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle firstRectangle = new Rectangle("Prostokąt 1");
            //double area = firstRectangle.Area();
            //Console.WriteLine("Pole prostokąta: " + area);
            firstRectangle.ShowInfo();

            Rectangle secondRectangle = new Rectangle("Prostokąt 2", 54, 99);
            secondRectangle.ShowInfo();
            

            Square firstSquare = new Square("Kwadrat Marcin");
            firstSquare.ShowInfo();

            Tetragon firstTetragon;
            if (new Random().Next() % 2 == 0)
                firstTetragon = new Square("Kolejny kwadrat", 5);
            else
                firstTetragon = new Rectangle("Kolejny prostokąt", 5, 7);
            double area = firstTetragon.Area();
            Console.WriteLine("Pole tetragon: " + area);

            firstTetragon.ShowInfo();


            List<Tetragon> shapeCollection = new List<Tetragon>();
            for (int i = 1; i < 5; i++)
            {
                int rest = new Random().Next() % 3;
                if (rest == 0)
                    shapeCollection.Add(new Square("Kolejny kwadrat", i));
                else if (rest == 1)
                    shapeCollection.Add(new Rectangle("Kolejny prostokąt", i, 2*i));
                else
                    shapeCollection.Add(new Trapeze("Kolejny trapez", i, i + 1, i+2, i+3, 2*i));
            }

            Console.WriteLine("Kolekcja figur");
            foreach (Tetragon tetragon in shapeCollection)
            {
                tetragon.ShowInfo();
            }


            Player[] players = new Player[2];
            //players[0] = new Human("X");
            //players[1] = new Bot("0");

            //Board board = new Board();
            /*
             1 2 3
             4 5 6
             7 8 9
              */

            /*int playerNumber = 1;
            do
            {
                playerNumber = playerNumber++ % 2;
                board.Add(players[playerNumber].Ruch());

            }while (board.IsEndGame());*/
            //}while (nie koniec gry (wygrana lub remis));


        }
    }

    class Player
    {
        public virtual int Ruch()
        {
            return new Random().Next()% 10 + 1;
        }
    }

    class Human: Player
    {
        public override int Ruch()
        {
            Console.WriteLine("Podaj numer pola");
            string pole = Console.ReadLine();

            return int.Parse(pole);
        }
    }

    class Bot : Player
    {
        public override int Ruch()
        {
            Console.WriteLine("Podaj numer pola");
            string pole = Console.ReadLine();

            return int.Parse(pole);
        }
    }
}
