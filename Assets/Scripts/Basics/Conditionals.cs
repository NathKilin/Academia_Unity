// Conditionals help us make DECISIONS in our code
// Think of it like: "IF something is true, THEN do this, ELSE do that"

using UnityEngine;

public class Conditionals : MonoBehaviour
{
    // Let's create some variables to use in our examples
    int playerScore = 75;
    int playerHealth = 60;
    bool hasKey = true;
    string weatherToday = "sunny";
    
    void Start()
    {
        // ===== BASIC IF STATEMENT =====
        // "If" checks if something is true
        // If it's true, the code inside { } runs
        if (playerHealth > 50)
        {
            Debug.Log("You have good health!");
        }
        
        // ===== IF-ELSE STATEMENT =====
        // If the condition is false, the "else" part runs instead
        if (hasKey == true) // == means "is equal to"
        {
            Debug.Log("You can open the door!");
        }
        else
        {
            Debug.Log("You need to find a key first.");
        }
        
        // ===== MULTIPLE CONDITIONS WITH ELSE IF =====
        // We can check multiple things one by one
        if (playerScore >= 90)
        {
            Debug.Log("Amazing! You got an A grade!");
        }
        else if (playerScore >= 70)
        {
            Debug.Log("Good job! You got a B grade!");
        }
        else if (playerScore >= 50)
        {
            Debug.Log("Not bad! You got a C grade.");
        }
        else
        {
            Debug.Log("Keep practicing! You can do better!");
        }
        
        // ===== COMPARISON OPERATORS =====
        // These are the symbols we use to compare things:
        // == means "is equal to"
        // != means "is NOT equal to"
        // > means "greater than"
        // < means "less than"
        // >= means "greater than or equal to"
        // <= means "less than or equal to"
        
        int temperature = 25;
        
        if (temperature > 30)
        {
            Debug.Log("It's hot outside!");
        }
        else if (temperature < 10)
        {
            Debug.Log("It's cold outside!");
        }
        else
        {
            Debug.Log("The weather is nice!");
        }
        
        // ===== COMBINING CONDITIONS WITH AND / OR =====
        // && means AND (both conditions must be true)
        // || means OR (at least one condition must be true)
        
        bool hasWeapon = true;
        int enemyCount = 3;
        
        // AND example: Both conditions must be true
        if (hasWeapon && enemyCount > 0)
        {
            Debug.Log("You have a weapon and there are enemies. Ready to fight!");
        }
        
        // OR example: At least one condition must be true
        if (playerHealth < 20 || playerScore < 30)
        {
            Debug.Log("Warning! Either your health or score is very low!");
        }
        
        // ===== NESTED IF (IF INSIDE IF) =====
        // We can put if statements inside other if statements
        if (weatherToday == "sunny")
        {
            Debug.Log("It's sunny today!");
            
            if (temperature > 20)
            {
                Debug.Log("And it's warm! Perfect day for a picnic!");
            }
        }
        
        // ===== PRACTICAL EXAMPLE =====
        // Let's make a simple game logic
        int coins = 150;
        int itemCost = 100;
        
        if (coins >= itemCost)
        {
            coins = coins - itemCost; // Buy the item
            Debug.Log("Item purchased! You have " + coins + " coins left.");
        }
        else
        {
            Debug.Log("Not enough coins! You need " + (itemCost - coins) + " more coins.");
        }
    }
}

// WHAT YOU LEARNED:
// 1. "if" checks if something is true and runs code if it is
// 2. "else" runs code when the "if" is false
// 3. "else if" lets us check multiple conditions
// 4. We use ==, !=, >, <, >=, <= to compare things
// 5. && means AND (both must be true)
// 6. || means OR (at least one must be true)
// 7. We can put if statements inside other if statements
// 8. Conditionals help us make decisions in our code!
