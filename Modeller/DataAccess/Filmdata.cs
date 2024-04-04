using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modeller.Models;
namespace Modeller.DataAccess
{
    internal class Filmdata
    {
        string path;
        List<string> errorfiles = new List<string>();
        public Filmdata()
        {
            path = "C:\\Csv\\TopratedRelations.csv";
        }
        public List<Models2> GetMovies()
        {
           
            
            List<Models2> allMovies = new List<Models2>();
            string[] movies = File.ReadAllLines(path);
            for (int i = 1; i < movies.Length; i++)
            {
                string[] splitMovies = movies[i].Split(';');
                try
                {
                   
                    string title = splitMovies[0];
                    string overview = splitMovies[1];
                    double rating = Convert.ToDouble(splitMovies[2]);
                    DateTime releaseDate = Convert.ToDateTime(splitMovies[3]);
                    string originalLanguage = splitMovies[4];
                                     
                    Models2 rando = new Models2(title, overview, rating, releaseDate, originalLanguage);
                    allMovies.Add(rando);
                    
                }
                catch (FormatException e)
                {
                    errorfiles.Add("fejl" + e.Message);
                }
              
                catch (Exception e)
                {
                    errorfiles.Add("fejl" + e.Message);


                }

            }
            return allMovies;


        }
    }
}
