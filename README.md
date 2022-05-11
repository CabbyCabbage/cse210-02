# cse210-02 - Hilo
Hilo game team activity for CSE 210

How to play:
- A card will be drawn with a value from 1 to 13.
- Guess whether the next card drawn will be higher or lower than the first card.
- A correct guess nets +100 points.
- An incorrect guess nets -75 points.
- If the new card is equal to the first card, it's game over.

Game ends when points reach zero, if the player busts, or when the player cashes out.

Author:
Caleb Schmid

# Program Information

Includes Program, Director, and Card class. The Program class will create a new Director and call the StartGame() method. The Director will direct the game and create a Card instance that changes its value through the game. 
