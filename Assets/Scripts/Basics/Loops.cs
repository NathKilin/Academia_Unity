// Loops help us REPEAT actions without writing the same code over and over
// Think of it like: "Do this thing 10 times" or "Keep doing this while something is true"

using UnityEngine;

public class Loops : MonoBehaviour
{
    void Start()
    {
        // ===== FOR LOOP =====
        // A "for" loop repeats code a specific number of times
        // Perfect when you know EXACTLY how many times you want to repeat
        
        Debug.Log("===== FOR LOOP EXAMPLES =====");
        
        // Let's count from 1 to 5
        // i = 0 means: start counting at 0
        // i < 5 means: keep going while i is less than 5
        // i++ means: add 1 to i after each loop
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Count: " + i);
        }
        // This will print: 0, 1, 2, 3, 4
        
        // Let's count from 1 to 10
        for (int number = 1; number <= 10; number++)
        {
            Debug.Log("Number: " + number);
        }
        
        // We can count BACKWARDS too!
        Debug.Log("Countdown starting...");
        for (int countdown = 5; countdown >= 1; countdown--)
        {
            Debug.Log(countdown + "...");
        }
        Debug.Log("Blast off!");
        
        // Let's use a loop to add up numbers
        int total = 0;
        for (int i = 1; i <= 5; i++)
        {
            total = total + i; // Add each number to the total
            Debug.Log("Adding " + i + ", total is now: " + total);
        }
        // Result: 1+2+3+4+5 = 15
        
        // ===== WHILE LOOP =====
        // A "while" loop keeps repeating AS LONG AS something is true
        // Perfect when you DON'T know exactly how many times to repeat
        
        Debug.Log("===== WHILE LOOP EXAMPLES =====");
        
        int health = 100;
        int damagePerSecond = 15;
        int seconds = 0;
        
        // Keep taking damage while health is above 0
        while (health > 0)
        {
            seconds++;
            health = health - damagePerSecond;
            Debug.Log("Second " + seconds + ": Health is now " + health);
        }
        Debug.Log("Player defeated after " + seconds + " seconds!");
        
        // ===== DO-WHILE LOOP =====
        // Similar to while, but ALWAYS runs at least once
        // It checks the condition AFTER running the code
        
        Debug.Log("===== DO-WHILE LOOP EXAMPLE =====");
        
        int dice = 6; // Starting value
        int rollCount = 0;
        
        do
        {
            rollCount++;
            Debug.Log("Roll " + rollCount + ": You rolled a " + dice);
            dice = Random.Range(1, 7); // Roll a new number (1 to 6)
        }
        while (dice != 6); // Keep rolling until we get a 6
        
        Debug.Log("Finally rolled a 6 after " + rollCount + " rolls!");
        
        // ===== BREAK AND CONTINUE =====
        // "break" stops the loop immediately
        // "continue" skips to the next loop iteration
        
        Debug.Log("===== BREAK EXAMPLE =====");
        
        // Find the first number divisible by 7
        for (int num = 1; num <= 50; num++)
        {
            if (num % 7 == 0) // % means "remainder after division"
            {
                Debug.Log("Found it! " + num + " is divisible by 7");
                break; // Stop the loop - we found what we wanted!
            }
        }
        
        Debug.Log("===== CONTINUE EXAMPLE =====");
        
        // Print only even numbers from 1 to 10
        for (int num = 1; num <= 10; num++)
        {
            if (num % 2 != 0) // If number is odd
            {
                continue; // Skip this number and go to the next one
            }
            Debug.Log(num + " is an even number");
        }
        
        // ===== NESTED LOOPS (LOOP INSIDE A LOOP) =====
        Debug.Log("===== NESTED LOOP EXAMPLE =====");
        
        // Let's create a simple multiplication table
        for (int row = 1; row <= 3; row++)
        {
            for (int col = 1; col <= 3; col++)
            {
                int result = row * col;
                Debug.Log(row + " x " + col + " = " + result);
            }
        }
        
        // ===== PRACTICAL EXAMPLE: SPAWNING ENEMIES =====
        Debug.Log("===== SPAWNING ENEMIES =====");
        
        int numberOfEnemies = 5;
        for (int i = 0; i < numberOfEnemies; i++)
        {
            Debug.Log("Spawning enemy #" + (i + 1) + " at position " + (i * 10));
        }
    }
}

// WHAT YOU LEARNED:
// 1. Loops help us repeat code without writing it multiple times
// 2. "for" loop: Use when you know HOW MANY times to repeat
//    - for (start; condition; increment) { code }
// 3. "while" loop: Use when you repeat UNTIL something is true
//    - while (condition) { code }
// 4. "do-while" loop: Like while, but runs at LEAST once
//    - do { code } while (condition);
// 5. "break" exits the loop immediately
// 6. "continue" skips to the next loop iteration
// 7. You can put loops inside other loops (nested loops)
// 8. Loops are super useful for repeating tasks in games!
