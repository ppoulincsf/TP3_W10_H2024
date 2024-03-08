namespace EFCS_Films_ETU
{
  public class Program
  {

    // Sources des données
    public const string ACTORS_FILE = "Files/actors.csv";
    public const string MOVIES_FILE = "Files/movies.csv";
    public const char ACTOR_SEPARATION_TOKEN = ';';

    // Catégories des films
    public const int ADVENTURE = 0;
    public const int ACTION = 1;
    public const int DRAMA = 2;
    public const int COMEDY = 3;
    public const int HORROR = 4;



    static void Main ( string[] args )
    {
      // List<String> allActors = ReadActorsFromFile (ACTORS_FILE);
      // List<Movie> allMovies = ReadMoviesFromFile (MOVIES_FILE);

      //WriteMoviesToFile (allMovies, MOVIES_FILE);
      // WriteFile (ACTORS_FILE, allActors.ToArray ());
    }

    #region FILE ACCESS
    /*
    private static void WriteMoviesToFile ( List<Movie> allMovies, string fileName )
    {
      string[] allLines = new string[allMovies.Count];
      for (int i = 0; i < allMovies.Count; i++)
      {
        allLines[i] = allMovies[i].Title;
        allLines[i] += "," + Convert.ToString (allMovies[i].Year);
        allLines[i] += "," + Convert.ToString (allMovies[i].Category);
        allLines[i] += "," + Convert.ToString (allMovies[i].Rating);
        allLines[i] += ",";

        for (int j = 0; j < allMovies[i].Actors.Count; j++)
        {
          if (j > 0)
            allLines[i] += ";";
          allLines[i] += Convert.ToString (allMovies[i].Actors[j]);
        }



      }
      WriteFile (fileName, allLines);
    }

    private static List<string> ReadActorsFromFile ( string filename )
    {
      List<string> actors = new List<string> ();
      string[] allLines = ReadFile (filename);
      for (int i = 0; i < allLines.Length; i++)
      {
        if (!String.IsNullOrEmpty (allLines[i]))
        {
          actors.Add (allLines[i]);
        }
      }
      return actors;
    }

    private static List<Movie> ReadMoviesFromFile ( string fileName )
    {
      List<Movie> allMovies = new List<Movie> ();
      string[] allLines = ReadFile (fileName);
      for (int i = 0; i < allLines.Length && !String.IsNullOrEmpty (allLines[i]); i++)
      {
        string[] currentLine = allLines[i].Split (",", StringSplitOptions.RemoveEmptyEntries);
        Movie newMovie = new Movie ();
        newMovie.Title = currentLine[0];
        newMovie.Year = int.Parse (currentLine[1]);
        newMovie.Rating = int.Parse (currentLine[3]);
        newMovie.Category = int.Parse (currentLine[2]);
        newMovie.Actors = new List<int> ();
        if (currentLine.Length > 4)
        {
          string[] actorsId = currentLine[4].Split (";", StringSplitOptions.RemoveEmptyEntries);
          foreach (string id in actorsId)
          {
            newMovie.Actors.Add (int.Parse (id));
          }
        }
        allMovies.Add (newMovie);
      }
      return allMovies;
    }

    /// <summary>
    /// Lit un fichier texte et stocke une ligne par cellule de tableau.
    /// </summary>
    /// <param name="fileName">Nom du fichier à lire. Il doit être situé
    /// dans le dossier bin/Debug/net6.0/Files</param>
    /// <param name="nbLinesMax">Nombres de lignes maximum qui pourront être lues dans le fichier</param>
    /// <returns>Un tableau des lignes lues</returns>
    public static string[] ReadFile ( string fileName )
    {
      StreamReader reader = new StreamReader (fileName, System.Text.Encoding.UTF8);
      List<string> allLines = new List<string> ();

      while (!reader.EndOfStream)
      {
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
        string line = reader.ReadLine ();
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
        allLines.Add (line);

      }

      reader.Close ();

      return allLines.ToArray ();
    }

    /// <summary>
    /// Écrit un fichier texte à partir d'un tableau de lignes.
    /// </summary>
    /// <param name="fileName">Nom du fichier à écrire. Il sera situé
    /// dans le dossier bin/Debug/net6.0/Files</param>
    /// <param name="linesToWrite">Tableau contenant les lignes à écrire</param>
    public static void WriteFile ( string fileName, string[] linesToWrite )
    {
      StreamWriter writer = new StreamWriter (fileName, false, System.Text.Encoding.UTF8);

      for (int i = 0; i < linesToWrite.Length; i++)
      {
        writer.WriteLine (linesToWrite[i]);
      }

      writer.Close ();
    }
    */
    #endregion 

  }
}