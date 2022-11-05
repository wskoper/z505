using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB.Models
{
    public class FilmModel
    {
        public int ID { get; set; }
        //[ID] [int] IDENTITY(1,1) NOT NULL;
        public string Title { get; set; }
        //[TITLE] [VNCHAR(200)] NOT NULL;
        public int Year { get; set; }
    }
}
