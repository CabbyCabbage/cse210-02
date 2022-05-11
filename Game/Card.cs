using System;

namespace hilo.Game {

    public class Card {

        public int value = 0;

        public Card() {
        }

        public void Draw() {
            Random rnd = new Random();
            value = rnd.Next(1,14);
        }

    }

}