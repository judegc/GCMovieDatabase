using UnitFourMovieDatabase;
//variables
Movie movieOne = new Movie("The Little Mermaid", 1, "Animated", 1989);
Movie movieTwo = new Movie("The Lion King", 1, "Animated", 1994);
Movie movieThree = new Movie("Halloween", 2, "Scary", 1978);
Movie movieFour = new Movie("The Hills Have Eyes", 2, "Scary", 2006);
Movie movieFive = new Movie("The Devil Wears Prada", 3, "Comedy", 2006);
Movie movieSix = new Movie("The Hangover", 3, "Comedy", 2009);
Movie movieSeven = new Movie("The Notebook", 4, "Romance", 2004);
Movie movieEight = new Movie("Dirty Dancing", 4, "Romance", 1978);
Movie movieNine = new Movie("Taken", 5, "Action", 2009);
Movie movieTen = new Movie("Terminator", 5, "Action", 1984);

//List
List<Movie> todaysShowings = new List<Movie> { movieOne, movieTwo, movieThree, movieFour, movieFive, movieSix, movieSeven, movieEight, movieNine, movieTen };
List<Movie> todaysShowingsSorted = todaysShowings.OrderBy(x => x.Title).ToList();
List<string> movieCategories = new List<string> ();
List<int> movieCategoryNums = new List<int> ();

//Program
Movie.FillLists(todaysShowingsSorted, movieCategories, movieCategoryNums);
Movie.MovieMenu(todaysShowingsSorted, movieCategoryNums, movieCategories);
Movie.WhichMovie(todaysShowingsSorted);
while (Console.ReadKey().Key != ConsoleKey.Enter) { }



































