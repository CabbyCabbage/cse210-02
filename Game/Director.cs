using System;
using System.Collections.Generic;

namespace hilo.Game {

    public class Director {

        Boolean isPlaying = true;
        
        Card card = new Card();
        
        string highLow = "";
        int score = 0;
        int prevValue = 0;
        
        public Director() {
            score = 300;
        } 

        public void StartGame() {
            while (isPlaying) {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        public void GetInputs() {
            card.Draw();
            prevValue = card.value;
            Console.WriteLine($"The card is: {card.value}");
            Console.Write($"Higher or lower? [h/l] ");
            highLow = Console.ReadLine();
        }

        public void DoUpdates() {
            if (!isPlaying)
            {
                return;
            }
            
            card.Draw();
            if (highLow == "h") {
                if (card.value > prevValue) {
                    score += 100;
                }
                else if (card.value < prevValue) {
                    score -= 75;
                }
            }
            else if (highLow == "l") {
                if (card.value > prevValue) {
                    score -= 75;
                }
                else if (card.value < prevValue) {
                    score += 100;
                }
            }

            if ((score <= 0) || card.value == prevValue) {
                isPlaying = false;
            }
        }

        public void DoOutputs() {
            if (!isPlaying) {
                Console.WriteLine("Game over, man!");
                return;
            }

            Console.WriteLine($"The next card was: {card.value}");
            Console.WriteLine($"Your score is {score}");
            Console.Write("Play again? (y/n) ");
            if (Console.ReadLine() == "n") {
                isPlaying = false;
            }
            Console.WriteLine();
        }
    }

}