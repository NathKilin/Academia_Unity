// Variables are like labeled boxes where we store information
// Each box can hold different types of things

using UnityEngine;

public class Variables : MonoBehaviour
{
    // These are called "fields" or "member variables"
    // We declare them here so the whole class can use them
    
    // INTEGER - A whole number (no decimal points)
    // "int" means integer, "playerHealth" is what we named this box
    // We put 100 inside this box using the = sign
    int playerHealth = 100;
    
    // FLOAT - A number with decimal points
    // "f" at the end tells C# this is a float number
    float playerSpeed = 5.5f;
    
    // STRING - Text (words and letters)
    // Strings are always wrapped in quotation marks " "
    string playerName = "Hero";
    
    // BOOLEAN - True or False (Yes or No)
    // "bool" can only be true or false
    bool isPlayerAlive = true;
    
    void Start()
    {
        // Let's print out all our variables to see them!
        Debug.Log("Player Name: " + playerName);
        Debug.Log("Player Health: " + playerHealth);
        Debug.Log("Player Speed: " + playerSpeed);
        Debug.Log("Is Player Alive? " + isPlayerAlive);
        
        // We can CHANGE what's inside our boxes (variables)!
        playerHealth = 75; // Oh no! Player took damage!
        Debug.Log("Player took damage! New health: " + playerHealth);
        
        // We can do MATH with numbers!
        int healingAmount = 10;
        playerHealth = playerHealth + healingAmount; // Add healing to health
        Debug.Log("Player healed! New health: " + playerHealth);
        
        // We can also write it shorter like this:
        playerHealth += 5; // This adds 5 to the current health
        Debug.Log("Found a small health pack! New health: " + playerHealth);
        
        // Let's change the player's name
        playerName = "Super Hero";
        Debug.Log("Player leveled up! New name: " + playerName);
        
        // Boolean (true/false) example
        if (playerHealth <= 0)
        {
            isPlayerAlive = false; // Player died
            Debug.Log("Game Over! Player is no longer alive.");
        }
        else
        {
            Debug.Log("Player is still alive and ready to fight!");
        }
    }
}

// WHAT YOU LEARNED:
// 1. Variables are boxes that store information
// 2. "int" stores whole numbers (1, 2, 100, -5)
// 3. "float" stores decimal numbers (1.5, 3.14, 5.5f)
// 4. "string" stores text ("Hello", "Player", "ABC")
// 5. "bool" stores true or false
// 6. We use = to put things in our variable boxes
// 7. We can change what's in the box anytime
// 8. We can do math with number variables
