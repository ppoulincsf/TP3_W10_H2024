using Xunit;
using EFCS_Films_ETU;
using System.Collections.Generic;
using System;
using System.Linq;
namespace TP3Tests
{
  public class TP3Tests
  {
    /*
    private List<Movie> CreateMovieList ( int nbMovies )
    {
      List<Movie> movieList = new List<Movie> ();
      for (int i = 0; i < nbMovies; i++)
      {
        Movie movie = new Movie ();
        movie.Title = $"Titre {i}";
        movie.Year = 2000 + i;
        movie.Category = (i % 10);
        movie.Rating = i % 10;
        movieList.Add (movie);
      }
      return movieList;
    }

    [Fact]
    public void InsertMovie_EmptyList_ListWithOneElement ()
    {
      const string ANY_TITLE = "Any Title";
      const int ANY_YEAR = 1999;
      const int ANY_CATEGORY = Program.DRAMA;
      const int ANY_RATING = 7;
      const int DEFAULT_NB_MOVIES = 0;

      List<Movie> allMovies = new List<Movie> ();


      Movie movieInfo = new Movie ();
      movieInfo.Title = ANY_TITLE;
      movieInfo.Year = ANY_YEAR;
      movieInfo.Category = ANY_CATEGORY;
      movieInfo.Rating = ANY_RATING;

      Library.InsertMovie (allMovies, movieInfo);

      Assert.Single (allMovies);
      Assert.Equal (ANY_TITLE, allMovies[DEFAULT_NB_MOVIES].Title);
      Assert.Equal (ANY_YEAR, allMovies[DEFAULT_NB_MOVIES].Year);
      Assert.Equal (ANY_CATEGORY, allMovies[DEFAULT_NB_MOVIES].Category);
      Assert.Equal (ANY_RATING, allMovies[DEFAULT_NB_MOVIES].Rating);
    }
    [Fact]
    public void InsertMovie_NullMovie_Exception ()
    {
      List<Movie> allMovies = new List<Movie> ();
      Assert.Throws<System.ArgumentException> (() => Library.InsertMovie (allMovies, null));
    }

    [Fact]
    public void InsertMovie_NotEmptyList_ListWithOneMoreElement ()
    {
      const string ANY_TITLE = "Any Title";
      const int ANY_YEAR = 1999;
      const int ANY_CATEGORY = Program.DRAMA;
      const int ANY_RATING = 7;
      const int DEFAULT_NB_MOVIES = 12;

      List<Movie> allMovies = CreateMovieList (DEFAULT_NB_MOVIES);


      Movie movieInfo = new Movie ();
      movieInfo.Title = ANY_TITLE;
      movieInfo.Year = ANY_YEAR;
      movieInfo.Category = ANY_CATEGORY;
      movieInfo.Rating = ANY_RATING;

      Library.InsertMovie (allMovies, movieInfo);

      Assert.Equal (DEFAULT_NB_MOVIES + 1, allMovies.Count);
      Assert.Equal (ANY_TITLE, allMovies[DEFAULT_NB_MOVIES].Title);
      Assert.Equal (ANY_YEAR, allMovies[DEFAULT_NB_MOVIES].Year);
      Assert.Equal (ANY_CATEGORY, allMovies[DEFAULT_NB_MOVIES].Category);
      Assert.Equal (ANY_RATING, allMovies[DEFAULT_NB_MOVIES].Rating);
    }
    [Fact]
    public void RemoveMovie_MovieNumBiggerThanListSize_Exception ()
    {
      const int DEFAULT_NB_MOVIES = 12;
      List<Movie> allMovies = CreateMovieList (DEFAULT_NB_MOVIES);
      Assert.Throws<ArgumentException> (() => { Library.RemoveMovie (allMovies, DEFAULT_NB_MOVIES + 1); });
    }
    [Fact]
    public void RemoveMovie_NegativeMovieNum_Exception ()
    {
      const int DEFAULT_NB_MOVIES = 12;
      List<Movie> allMovies = CreateMovieList (DEFAULT_NB_MOVIES); ;
      Assert.Throws<ArgumentException> (() => { Library.RemoveMovie (allMovies, -1); });
    }
    [Fact]
    public void RemoveMovie_NotEmptyListAndValidMovieNum_ListWithOneMoreLessElement ()
    {

      const int DEFAULT_NB_MOVIES = 12;
      const int ANY_VALID_MOVIE_NUM = DEFAULT_NB_MOVIES / 2;

      List<Movie> allMovies = CreateMovieList (DEFAULT_NB_MOVIES);

      Library.RemoveMovie (allMovies, ANY_VALID_MOVIE_NUM);

      Assert.Equal (DEFAULT_NB_MOVIES - 1, allMovies.Count);
    }
    [Fact]
    public void UpdateMovie_MovieNumBiggerThanListSize_Exception ()
    {
      const int DEFAULT_NB_MOVIES = 12;

      List<Movie> allMovies = CreateMovieList (DEFAULT_NB_MOVIES);
      Assert.Throws<ArgumentException> (() => { Library.UpdateMovie (allMovies, DEFAULT_NB_MOVIES + 1, new Movie ()); });
    }
    [Fact]
    public void UpdateMovie_NegativeMovieNum_Exception ()
    {
      const int DEFAULT_NB_MOVIES = 12;
      List<Movie> allMovies = CreateMovieList (DEFAULT_NB_MOVIES); ;
      Assert.Throws<ArgumentException> (() => { Library.UpdateMovie (allMovies, -1, new Movie ()); });
    }
    [Fact]
    public void UpdateMovie_NotEmptyListAndValidMovieNum_ListWithMovieUpdated ()
    {

      const int DEFAULT_NB_MOVIES = 12;
      const int ANY_VALID_MOVIE_NUM = DEFAULT_NB_MOVIES / 2;

      List<Movie> allMovies = CreateMovieList (DEFAULT_NB_MOVIES);
      const string ANY_TITLE = "Any Title";
      const int ANY_YEAR = 1999;
      const int ANY_CATEGORY = Program.DRAMA;
      const int ANY_RATING = 7;
      Movie movieInfo = new Movie ();
      movieInfo.Title = ANY_TITLE;
      movieInfo.Year = ANY_YEAR;
      movieInfo.Category = ANY_CATEGORY;
      movieInfo.Rating = ANY_RATING;

      Library.UpdateMovie (allMovies, ANY_VALID_MOVIE_NUM, movieInfo);

      Assert.Equal (DEFAULT_NB_MOVIES, allMovies.Count);
      Assert.Equal (movieInfo, allMovies[ANY_VALID_MOVIE_NUM]);
    }
    [Fact]
    public void UpdateMovie_NullMovie_Exception ()
    {
      const int DEFAULT_NB_MOVIES = 12;

      List<Movie> allMovies = CreateMovieList (DEFAULT_NB_MOVIES);
      Assert.Throws<ArgumentException> (() => { Library.UpdateMovie (allMovies, DEFAULT_NB_MOVIES + 1, null); });
    }
    */
  }
}