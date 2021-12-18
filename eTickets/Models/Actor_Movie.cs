using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor_Movie
    {

        //Entity Framework is smart enough to recognize foreign keys
        public int MovieId { get; set; }    //Foreign Keys
        public Movie Movie { get; set; }  
        
        public int ActorId { get; set; }
        public Actor Actor { get; set; }


    }
}
