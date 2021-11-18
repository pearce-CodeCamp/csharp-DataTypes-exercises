using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The first sentence of Alice’s Adventures in Wonderland is below. 
             * Store this sentence in a string, and then prompt the user for a term 
             * to search for within this string. Print whether or not the search 
             * term was found. Make the search case-insensitive, so that searching for 
             * “alice”, for example, prints true.*/

            string sentence = "Alice was beginning to get very tired of sitting " +
                "by her sister on the bank, and of having nothing to do: once or twice " +
                "she had peeped into the book her sister was reading, but it had no " +
                "pictures or conversations in it, 'and what is the use of a book,' thought Alice " +
                "'without pictures or conversation?'";
            string lowerSentence = sentence.ToLower();
            Console.WriteLine("Enter a term to see if it exists in the sentence:");
            // method chaining solution
            string term = Console.ReadLine().ToLower();
            // no method chaining solution
            //string lowerTerm = term.ToLower();

            // now we need to see if the sentence contains the term
            // solution in JS: console.log(lowerSentence.includes(term)); 
            Console.WriteLine(lowerSentence.Contains(term));
            
        }
    }
}
