using System;

namespace hilo.Game {

    // Card class holds a value card and can draw a new value
    public class Card {

        public int value = 0;

        // Constructor instantiates a new Card
        public Card() {
        }

        // Generates a new value for the card between 1-13
        public void Draw() {
            Random rnd = new Random();
            value = rnd.Next(1,14);
        }

    }

}