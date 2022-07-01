
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Foo
{
    /*
     * Complete the 'SearchSuggestions' function below.
     *
     * The function is expected to return a list of string lists (2D_STRING_ARRAY).
     * The function accepts following parameters:
     * 	1. List (STRING_ARRAY) - reviewsRepository
     * 	2. String - userInput
     */

    

    public static List<List<string>> SearchSuggestions(List<string> reviewsRepository, string userInput)
    {
        List<List<string>> searchSuggestions = new List<List<string>>();

        reviewsRepository.Sort(); //sort before any other opartions so not have to sort the resulting lists
        
        for (int i = 2; i <= userInput.Length; i++)
        {
            string subStr = userInput.Substring(0, i);//cuts off userInput after i index

            //temp list matches to get all matches with the lambda expression, and then take the specified max of 3 strings
            List<string> matches = reviewsRepository.FindAll(reviewsRepository => reviewsRepository.StartsWith(subStr)).Take(3).ToList();
            
            //add said temp matches to the result
            searchSuggestions.Add(matches);
        }
        return searchSuggestions;
    }
}

public class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("How many words in review repository: ");
        int reviewsRepositoryCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> reviewsRepository = new List<string>();

        Console.WriteLine("Please enter words into repository: ");
        for (int i = 0; i < reviewsRepositoryCount; i++)
        {
            Console.Write((i+1) + ". word: ");
            string reviewsRepositoryItem = Console.ReadLine();
            reviewsRepository.Add(reviewsRepositoryItem);
        }
        Console.WriteLine("The word you want to 'search': ");
        string userInput = Console.ReadLine();

        List<List<string>> foo = Foo.SearchSuggestions(reviewsRepository, userInput);
        Console.WriteLine("\n---------------------------\n");

        Console.WriteLine(String.Join("\n", foo.Select(x => String.Join(" - ", x))));
    }
}