using System.Collections;
using System;
using System.Linq;

public class JogoForca
    {
        string targetWord;
        string spaceOfWord; //_ _ _ _ _ _
        string [] wordList;
        ArrayList rightGuess;
        ArrayList wrongGuess;
        const int numGuess = 5;

        public JogoForca()
        {
            wordList = new string[] {"uvv", "casa", "borboleta"};
            rightGuess = new ArrayList();
            wrongGuess = new ArrayList();
        }

        public string DrawWord() {
            Random rnd = new Random();
            int drawedWord = rnd.Next(0, wordList.Length - 1);
            targetWord = wordList[drawedWord];
            return targetWord;
        }

        public bool GuessLetter(char guess) {
            if(rightGuess.Contains(guess) || wrongGuess.Contains(guess)) {
                Console.WriteLine("Letra já chutada. Escolha outra.");
                return false;
            }
            
            if(targetWord.Contains(guess)) {
                rightGuess.Add(guess);
                return true;
            }
            else {
                wrongGuess.Add(guess);
                return false;
            }
        }

        public bool IsEndGame() {
            if (wrongGuess.Count == 5) {
                Console.WriteLine("Você perdeu!");
                return true;
            }

            int diferentCharNumberInTheWord = targetWord.Distinct().Count();
            if(rightGuess.Count == diferentCharNumberInTheWord) {
                Console.WriteLine("Você Ganhou!!");
                return true;
            }

            return false;
        }

        public void ShowGameStatus() {
            Console.WriteLine("Right Guesses");
            for(int i = 0; i < rightGuess.Count; i++) {
                Console.Write(rightGuess[i] + " ");
            }

            Console.WriteLine("Wrong Guesses");
            for(int i = 0; i < wrongGuess.Count; i++){
                Console.Write(wrongGuess[i] + " ");
            }

            Console.WriteLine($"Você ainda tem : {numGuess - rightGuess.Count - wrongGuess.Count} chutes");
        }
    }