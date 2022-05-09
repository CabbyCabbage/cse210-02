using System;

namespace hilo.Game {

    public class Card {

        int value = 0;

        public Card() {
        }

        public Draw() {
            Random rnd = new Random();
            value = rnd.Next(1,14);
        }

    }

}