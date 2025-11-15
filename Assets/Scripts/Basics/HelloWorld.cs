// This is a comment! Comments help us understand what the code does.
// The computer ignores comments - they're just for humans to read.

// These "using" lines are like bringing tools from a toolbox
// We need them to use Unity features
using UnityEngine;

// This is our class - think of it as a recipe or blueprint
// "public" means anyone can use it
// "class" means we're creating a new type of thing
// "HelloWorld" is the name we chose (it should match the file name)
// ": MonoBehaviour" means this can be attached to objects in Unity
public class HelloWorld : MonoBehaviour
{
    // This is a special function called "Start"
    // Unity automatically runs this function ONCE when the game starts
    // Think of it like pressing the "play" button
    void Start()
    {
        // Debug.Log is like a magic printing machine
        // It shows messages in the Unity console (the message window)
        // Everything between the quotation marks " " is text we want to show
        Debug.Log("Hello, World! Welcome to Unity!");
        
        // Let's print another message
        Debug.Log("This is my first Unity script!");
        
        // We can print numbers too!
        Debug.Log("My favorite number is: 42");
    }
    
    // This is another special function called "Update"
    // Unity runs this function MANY TIMES per second (every frame)
    // Think of it like checking something over and over again
    void Update()
    {
        // Be careful! This will print A LOT because Update runs many times per second
        // We're leaving this empty for now
        // If you want to try it, remove the // from the next line:
        // Debug.Log("Update is running!");
    }
}

// WHAT YOU LEARNED:
// 1. Comments help us understand code (they start with //)
// 2. "using" brings in tools we need
// 3. "class" creates a blueprint for our code
// 4. "Start()" runs once when the game begins
// 5. "Update()" runs many times per second
// 6. "Debug.Log()" shows messages in the console
