using System;

    class Program
    {
        static void Main(string[] args)
        {
            bool finish = false;

            JogoForca game = new JogoForca();
            game.DrawWord();

            do {
            game.ShowGameStatus();
            char guess = Console.ReadKey().KeyChar;
            game.GuessLetter(guess);
            finish = game.IsEndGame();
            } while (!finish);
        }
    }