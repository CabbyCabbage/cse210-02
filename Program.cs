// Hilo program | CSE 210 Assignment 02
// Authors: Caleb Schmid

using hilo.Game;

namespace hilo {

    // Main Program class
    class Program {
        
        // Initializes instance of the Director class and starts the game
        static void Main(string[] args) {

            Director director = new Director();
            director.StartGame();

        }
    }
}
