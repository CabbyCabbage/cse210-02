using System;
using System.Collections.Generic;

namespace hilo.Game {

    /// Class Director directs the game, when it starts and ends, and everything in between
    public class Director {
        
        Boolean isPlaying = true;
        
        Card card = new Card();
        
        string highLow = "";
        int score = 0;
        int prevValue = 0;
        
        /// Constructor intializes the points counter to 300
        public Director() {
            score = 300;
        } 

        /// Starts the game, looping until isPlaying is false
        public void StartGame() {
            while (isPlaying) {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// Draws the first card, then allows the user to decide to guess high or low
        public void GetInputs() {
            card.Draw();
            prevValue = card.value;
            Console.WriteLine($"The card is: {card.value}");
            Console.Write($"Higher or lower? [h/l] ");
            highLow = Console.ReadLine();
        }

        /// While playing, updates points according to the user's guess
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

        /// Outputs the scores and recieves input from the user whether to continue play
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