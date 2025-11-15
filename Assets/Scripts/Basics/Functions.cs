// Functions (also called Methods) are like mini-programs inside our program
// They are reusable pieces of code that do specific jobs
// Think of them like recipes - you write the recipe once, then use it many times!

using UnityEngine;

public class Functions : MonoBehaviour
{
    void Start()
    {
        // Let's CALL (use) our functions!
        // Calling a function means telling it to run
        
        Debug.Log("===== CALLING SIMPLE FUNCTIONS =====");
        
        // Call a function with no parameters
        SayHello();
        SayHello(); // We can call it as many times as we want!
        
        // Call a function with one parameter
        GreetPlayer("Alice");
        GreetPlayer("Bob");
        
        // Call a function with multiple parameters
        AddNumbers(5, 3);
        AddNumbers(10, 20);
        
        Debug.Log("===== FUNCTIONS THAT RETURN VALUES =====");
        
        // These functions GIVE US BACK a value we can use
        int sum = CalculateSum(7, 8);
        Debug.Log("7 + 8 = " + sum);
        
        int product = Multiply(4, 5);
        Debug.Log("4 x 5 = " + product);
        
        // We can use the result directly
        Debug.Log("Is 15 even? " + IsEven(15));
        Debug.Log("Is 20 even? " + IsEven(20));
        
        Debug.Log("===== PRACTICAL GAME EXAMPLES =====");
        
        // Damage calculation
        int damage = CalculateDamage(50, 10);
        Debug.Log("Total damage dealt: " + damage);
        
        // Level up check
        bool canLevelUp = CheckLevelUp(1500, 1000);
        if (canLevelUp)
        {
            Debug.Log("Congratulations! You leveled up!");
        }
        
        // Health display
        DisplayHealthBar(75, 100);
    }
    
    // ===== SIMPLE FUNCTION (NO PARAMETERS, NO RETURN) =====
    // "void" means this function doesn't give back any value
    // The parentheses () are empty because it doesn't take any input
    void SayHello()
    {
        Debug.Log("Hello from the function!");
    }
    
    // ===== FUNCTION WITH ONE PARAMETER =====
    // Parameters are like ingredients we give to the function
    // "string name" means this function needs a text input called "name"
    void GreetPlayer(string name)
    {
        Debug.Log("Welcome, " + name + "!");
    }
    
    // ===== FUNCTION WITH MULTIPLE PARAMETERS =====
    // We can give a function multiple pieces of information
    void AddNumbers(int number1, int number2)
    {
        int result = number1 + number2;
        Debug.Log(number1 + " + " + number2 + " = " + result);
    }
    
    // ===== FUNCTION THAT RETURNS A VALUE =====
    // Instead of "void", we write the type of value we want to give back
    // "return" is like saying "here's your answer!"
    int CalculateSum(int a, int b)
    {
        int sum = a + b;
        return sum; // Give back the sum to whoever called this function
    }
    
    // ===== ANOTHER RETURN EXAMPLE =====
    int Multiply(int x, int y)
    {
        return x * y; // We can return directly without storing in a variable
    }
    
    // ===== FUNCTION THAT RETURNS TRUE/FALSE =====
    // This checks if a number is even
    bool IsEven(int number)
    {
        if (number % 2 == 0) // % gives us the remainder
        {
            return true; // Yes, it's even
        }
        else
        {
            return false; // No, it's odd
        }
    }
    
    // ===== PRACTICAL GAME FUNCTION: CALCULATE DAMAGE =====
    // Takes base damage and armor, returns final damage
    int CalculateDamage(int baseDamage, int armor)
    {
        int finalDamage = baseDamage - armor;
        
        // Make sure damage doesn't go below 0
        if (finalDamage < 0)
        {
            finalDamage = 0;
        }
        
        return finalDamage;
    }
    
    // ===== PRACTICAL GAME FUNCTION: CHECK IF CAN LEVEL UP =====
    // Returns true if current XP is enough to level up
    bool CheckLevelUp(int currentXP, int xpNeeded)
    {
        return currentXP >= xpNeeded;
    }
    
    // ===== PRACTICAL GAME FUNCTION: DISPLAY HEALTH =====
    void DisplayHealthBar(int currentHealth, int maxHealth)
    {
        float percentage = (float)currentHealth / maxHealth * 100;
        Debug.Log("Health: " + currentHealth + "/" + maxHealth + " (" + percentage + "%)");
        
        if (currentHealth <= maxHealth * 0.2f) // 20% or less
        {
            Debug.Log("WARNING: Low health!");
        }
    }
    
    // ===== FUNCTION WITH DEFAULT PARAMETER VALUE =====
    // We can give parameters default values
    void SpawnEnemy(string enemyType = "Goblin", int count = 1)
    {
        Debug.Log("Spawning " + count + " " + enemyType + "(s)");
    }
    
    // This function can be called in different ways:
    // SpawnEnemy(); // Uses defaults: "Goblin", 1
    // SpawnEnemy("Dragon"); // Uses: "Dragon", 1
    // SpawnEnemy("Orc", 5); // Uses: "Orc", 5
}

// WHAT YOU LEARNED:
// 1. Functions are reusable blocks of code that do specific jobs
// 2. "void" means the function doesn't return a value
// 3. Parameters are inputs we give to functions (like ingredients)
// 4. "return" gives back a value from the function
// 5. We can call functions as many times as we want
// 6. Functions make code organized and easier to understand
// 7. We write the function ONCE, then use it MANY times
// 8. Function format: returnType FunctionName(parameters) { code }

// WHY USE FUNCTIONS?
// 1. Avoid repeating the same code
// 2. Make code easier to read and understand
// 3. Fix bugs in one place instead of many places
// 4. Break big problems into smaller, manageable pieces
