using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitFourMovieDatabase;
//The application stores a list of 10 movies and displays them by category.
//The user can enter any of the following categories to display the films in the list that match the category: animated, drama, horror, scifi.
//After the list is displayed, the user is asked if he or she wants to continue. If no, the program ends.

namespace UnitFourMovieDatabase
{
    public class Movie
    {
        //Constructor
        public Movie(string argTitle, int argCategoryNumber, string argCategory, int argYearReleased)
        {
            Title = argTitle;
            CategoryNumber = argCategoryNumber;
            Category = argCategory;
            YearReleased = argYearReleased;
        }
        //Properties
        public string Title { get; set; }
        public int CategoryNumber { get; set; }
        public string Category { get; set; }
        public int YearReleased { get; set; }
        //Methods
        public static void FillLists(List<Movie> movieList, List<string> categoryList, List<int> categoryListNums)
        {
            foreach (Movie show in movieList)
            {
                categoryList.Add(show.Category);
            }
            categoryList.Sort();
            foreach (Movie show in movieList)
            {
                categoryListNums.Add(show.CategoryNumber);
            }
            categoryListNums.Sort();
        }
        public static void MovieMenu(List<Movie> movieList, List<int> movieInt, List<string> movieString)
        {
            var movieIntUnique = movieInt.Distinct();
            List<int> mIList = movieIntUnique.ToList();
            var movieStringUnique = movieString.Distinct();
            List<string> mSList = movieStringUnique.ToList();
            int i = 0;
            Console.WriteLine("Welcome to Family Video! Please see our move categories below:");
            Console.WriteLine("");
            foreach (int movie in mIList)
            {
                Console.WriteLine(String.Format("{0,-15} {1, -5}", mIList[i], mSList[i]));
                i++;
            }
        }
        public static string WhichMovie(List<Movie> movieList)
        {
            string repeatInput = "";
            do
            {
                Console.WriteLine("Please select the movie category by number or name:");
                string userInput = Console.ReadLine();
                int userInputNum;
                bool userInputParse = int.TryParse(userInput, out userInputNum);
                int i = 0;
                foreach (Movie movie in movieList)
                {

                    if (movie.Category.ToLower() == userInput.ToLower())
                    {
                        i++;
                        Console.WriteLine(String.Format("{0, -30} {1, 30}", movie.Title, $"Released in { movie.YearReleased}"));
                    }
                    else if (movie.CategoryNumber == userInputNum)
                    {
                        i++;
                        Console.WriteLine(String.Format("{0, -30} {1, 30}", movie.Title, $"Released in { movie.YearReleased}"));
                    }
                    else if (movie.Category.ToLower() != userInput.ToLower() && movie.CategoryNumber != userInputNum)
                    {
                        continue;
                    }                  
                }
                if (i == 0)
                {
                    Console.WriteLine("I'm sorry, that is not a valid selection.");
                }
                i = 0;
                Console.WriteLine("Would you like to search another category? y/n");
                repeatInput = Console.ReadLine();
            } while (repeatInput.ToLower() == "y");
            Console.WriteLine("Goodbye! Press <Enter> to close the program:");
            return "";
        }
    }
}

