// This is a COMPLETE MINI-GAME example that uses everything you learned!
// It combines: Variables, Conditionals, Loops, and Functions
// This is a simple text-based number guessing game

using UnityEngine;

public class SimpleGame : MonoBehaviour
{
    // ===== GAME VARIABLES =====
    // These store information about our game
    
    int secretNumber;           // The number the player needs to guess
    int playerGuess;            // The player's current guess
    int attemptsLeft;           // How many guesses the player has left
    int maxAttempts = 5;        // Maximum number of guesses allowed
    bool gameWon = false;       // Did the player win?
    bool gameOver = false;      // Is the game finished?
    
    // Score system
    int score = 0;              // Player's current score
    int pointsPerWin = 100;     // Points earned for winning
    
    void Start()
    {
        // Start a new game when the script begins
        StartNewGame();
        
        // Let's simulate the game playing automatically
        // (In a real game, you'd get input from the player)
        PlayGameAutomatically();
    }
    
    // ===== FUNCTION: START A NEW GAME =====
    // This sets up everything we need for a new game
    void StartNewGame()
    {
        Debug.Log("========================================");
        Debug.Log("🎮 WELCOME TO THE NUMBER GUESSING GAME!");
        Debug.Log("========================================");
        
        // Pick a random secret number between 1 and 20
        secretNumber = Random.Range(1, 21);
        
        // Reset game variables
        attemptsLeft = maxAttempts;
        gameWon = false;
        gameOver = false;
        
        Debug.Log("I'm thinking of a number between 1 and 20.");
        Debug.Log("You have " + maxAttempts + " attempts to guess it!");
        Debug.Log("Your current score: " + score);
        Debug.Log("");
    }
    
    // ===== FUNCTION: MAKE A GUESS =====
    // This is called when the player makes a guess
    void MakeGuess(int guess)
    {
        // Check if game is already over
        if (gameOver)
        {
            Debug.Log("Game is over! Start a new game.");
            return; // Exit the function early
        }
        
        // Store the player's guess
        playerGuess = guess;
        attemptsLeft--; // Remove one attempt
        
        Debug.Log("Attempt #" + (maxAttempts - attemptsLeft) + ": You guessed " + playerGuess);
        
        // ===== CONDITIONAL: CHECK THE GUESS =====
        if (playerGuess == secretNumber)
        {
            // Player won!
            PlayerWins();
        }
        else if (playerGuess < secretNumber)
        {
            // Guess was too low
            Debug.Log("❌ Too low! Try a higher number.");
            GiveHint();
        }
        else // playerGuess > secretNumber
        {
            // Guess was too high
            Debug.Log("❌ Too high! Try a lower number.");
            GiveHint();
        }
        
        // Check if player ran out of attempts
        if (attemptsLeft <= 0 && !gameWon)
        {
            PlayerLoses();
        }
        
        Debug.Log(""); // Empty line for spacing
    }
    
    // ===== FUNCTION: GIVE HINT =====
    // Helps the player by showing how many attempts are left
    void GiveHint()
    {
        // Show attempts left
        Debug.Log("💡 Attempts remaining: " + attemptsLeft);
        
        // Give extra hint if player is running out of attempts
        if (attemptsLeft <= 2 && attemptsLeft > 0)
        {
            Debug.Log("⚠️ Warning: Only " + attemptsLeft + " attempts left!");
        }
        
        // Give range hint
        int difference = Mathf.Abs(playerGuess - secretNumber);
        if (difference <= 2)
        {
            Debug.Log("🔥 You're VERY close!");
        }
        else if (difference <= 5)
        {
            Debug.Log("🌡️ You're getting warm!");
        }
        else
        {
            Debug.Log("❄️ You're cold!");
        }
    }
    
    // ===== FUNCTION: PLAYER WINS =====
    void PlayerWins()
    {
        gameWon = true;
        gameOver = true;
        
        Debug.Log("✅ ========================================");
        Debug.Log("✅ CORRECT! You won!");
        Debug.Log("✅ The secret number was: " + secretNumber);
        Debug.Log("✅ ========================================");
        
        // Calculate bonus points based on attempts left
        int bonusPoints = attemptsLeft * 20;
        int totalPoints = pointsPerWin + bonusPoints;
        score += totalPoints;
        
        Debug.Log("🏆 You earned " + pointsPerWin + " points!");
        Debug.Log("🎁 Bonus for attempts left: " + bonusPoints + " points!");
        Debug.Log("⭐ Total Score: " + score);
    }
    
    // ===== FUNCTION: PLAYER LOSES =====
    void PlayerLoses()
    {
        gameOver = true;
        
        Debug.Log("❌ ========================================");
        Debug.Log("❌ Game Over! You ran out of attempts.");
        Debug.Log("❌ The secret number was: " + secretNumber);
        Debug.Log("❌ ========================================");
        Debug.Log("Current Score: " + score);
        Debug.Log("Better luck next time!");
    }
    
    // ===== FUNCTION: DISPLAY GAME STATS =====
    void DisplayGameStats()
    {
        Debug.Log("📊 ===== GAME STATISTICS =====");
        Debug.Log("Total Score: " + score);
        Debug.Log("Last Secret Number: " + secretNumber);
        Debug.Log("========================================");
    }
    
    // ===== FUNCTION: SIMULATE AUTOMATIC GAMEPLAY =====
    // This plays the game automatically so you can see how it works
    // In a real game, the player would input their guesses
    void PlayGameAutomatically()
    {
        Debug.Log("🤖 Auto-playing to demonstrate the game...");
        Debug.Log("");
        
        // ===== LOOP: MAKE SEVERAL GUESSES =====
        // Let's make random guesses until we run out or win
        for (int i = 0; i < maxAttempts; i++)
        {
            // If game is over, stop the loop
            if (gameOver)
            {
                break;
            }
            
            // Make a random guess between 1 and 20
            int randomGuess = Random.Range(1, 21);
            MakeGuess(randomGuess);
        }
        
        // Show final statistics
        DisplayGameStats();
    }
}

// ===== WHAT YOU LEARNED FROM THIS COMPLETE EXAMPLE =====
//
// 1. VARIABLES - We used many variables to track game state:
//    - secretNumber, playerGuess, attemptsLeft, score, etc.
//
// 2. CONDITIONALS - We made decisions based on conditions:
//    - if (playerGuess == secretNumber) - Check if guess is correct
//    - if (attemptsLeft <= 0) - Check if game should end
//    - if (difference <= 2) - Give hints based on how close the guess is
//
// 3. LOOPS - We repeated actions:
//    - for loop to make multiple guesses automatically
//    - Used break to exit loop early when game ends
//
// 4. FUNCTIONS - We organized code into reusable pieces:
//    - StartNewGame() - Sets up a new game
//    - MakeGuess() - Handles each guess
//    - GiveHint() - Provides hints to the player
//    - PlayerWins() - Handles winning
//    - PlayerLoses() - Handles losing
//
// 5. GAME LOGIC - We combined everything to create a complete game:
//    - Random number generation
//    - Score system with bonuses
//    - Attempt tracking
//    - Win/lose conditions
//    - Helpful feedback and hints
//
// ===== TRY MODIFYING THIS CODE =====
//
// Easy changes:
// - Change the range of numbers (currently 1-20)
// - Change the number of attempts (currently 5)
// - Change the points earned for winning
//
// Medium changes:
// - Add difficulty levels (easy/medium/hard)
// - Create a hint system that costs points
// - Add a "play again" feature
//
// This example shows how simple concepts combine to create fun games!
