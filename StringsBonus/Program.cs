using System;

namespace StringsBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Extend the previous exercise. Assume the user enters a word that is in the sentence. 
             * Print out its index within the string and its length. Next, remove the word from the 
             * string and print the sentence again to confirm your code. Remember that strings are 
             * immutable, so you will need to reassign the old sentence variable or create a new one 
             * to store the updated phrase.
            */
            string sentence = "Alice was beginning to get very tired of sitting " +
               "by her sister on the bank, and of having nothing to do: once or twice " +
               "she had peeped into the book her sister was reading, but it had no " +
               "pictures or conversations in it, 'and what is the use of a book,' thought Alice " +
               "'without pictures or conversation?'";
            Console.WriteLine(sentence);
            string lowerSentence = sentence.ToLower();
            Console.WriteLine("Enter a term to remove it from the sentence:");
            string term = Console.ReadLine().ToLower();

            // other solution using Replace instead of Remove
            // no need for foundIndex or the term length
            // replaces the term in the sentence with an empty string
            string newSentenceReplace = sentence.Replace(term, "");
            Console.WriteLine(newSentenceReplace);

            // commented out the original solution below

            // find index of term in sentence
            /*int foundIndex = lowerSentence.IndexOf(term);
            Console.WriteLine($"Term: '{term}', Index: {foundIndex}, Length: {term.Length}");*/
            //remove the term from the sentence using its index and its length
            //store the new sentence with the removed term as a variable and print it
            // The Remove needs a start and end index value, and it removes all characters between
            // these 2 indexes
            // ie if term is 'beginning', foundIndex is 10 and length is 9
            // so, when passed foundIndex and term.Length, the Remove method
            // starts at index 10, and removes the next 9 characters*/
           /* string newSentence = sentence.Remove(foundIndex, term.Length);
            Console.WriteLine(newSentence);*/


        }
    }
}
