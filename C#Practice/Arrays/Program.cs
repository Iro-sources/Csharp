// See https://aka.ms/new-console-template for more information
using System;

// Ask user for allowed characters
Console.WriteLine("Enter allowed characters: ");
String allowed = Console.ReadLine();


// Ask how many words the user wants to input
Console.WriteLine("Enter number of words: ");
int n = Int.parse(Console.ReadLine());

// Initialize an array of strings to store the user's words
String[] words = new String[n];
System.out.println("Enter the words:");
for (int i = 0; i < n; i++)
{
    words[i] = scanner.nextLine();
}

// Variable to count the number of consistent words
int count = 0;

// Loop through each word to check for consistency
for (String word : words)
{
    // Assume the word is consistent initially
    boolean isConsistent = true;

    // Check each character in the word
    for (char c : word.toCharArray())
    {
        // If any character is not in allowed, mark as inconsistent and stop
        if (allowed.indexOf(c) == -1)
        {
            isConsistent = false;
            break;
        }
    }

    // If word is consistent, increase the count
    if (isConsistent)
    {
        count++;
    }
}

// Output the number of consistent strings
System.out.println("Number of consistent strings: " + count);

// Close the scanner to free resources
scanner.close();
