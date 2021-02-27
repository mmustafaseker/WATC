using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampData
{
    [Table("Matches")]
    public class Match
    {
        public int Id { get; set; }


        [Required]
        public DateTime MatchTime { get; set; }



        [Required]
        public int Team1Id { get; set; }
        //macın takımı olur
        public virtual Team Team1 { get; set; }


        [Required]
        public int Team2Id { get; set; }
        //macın takımı olur
        public virtual Team Team2 { get; set; }


        [Required]
        public int Score1 { get; set; }

        [Required]
        public int Score2 { get; set; }


        //null olabilir
        public  Result? Result { get; set; }
    }
}
