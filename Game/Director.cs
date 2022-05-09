using System;
using System.Collections.Generic;

namespace hilo.Game {

    public class Director {

        Card card = new Card();
        Boolean isPlaying = true;
        string highLow = "";
        int score = 0;
        int iniValue = 0;
        
        public Director() {
            score = 300;
        } 

        public void StartGame() {
            
        }

        public void GetInputs() {
            card.Draw();
            currValue = card.value;
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
                if (iniValue > card.value) {
                    score += 100;
                }
                else if (iniValue < card.value) {
                    score -= 75;
                }
            }
            else if (highLow == "l") {
                if (iniValue > card.value) {
                    score -= 75;
                }
                else if (iniValue < card.value) {
                    score += 100;
                }
            }
        }

        public void DoOutputs() {

        }
    }

}