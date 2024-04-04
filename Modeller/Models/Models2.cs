using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeller.Models
{
    internal class Models2
    {

        string titel;
        string overview;
        double voteaverage;
        DateTime releasedate;
        string language;


       
        public Models2( string titel, string overview, double voteaverage, DateTime releasedate, string language)
        {
            this.titel = titel;
            this.overview = overview;
            this.voteaverage = voteaverage;
            this.releasedate = releasedate;
            this.language = language;
            
        }
    }
}
