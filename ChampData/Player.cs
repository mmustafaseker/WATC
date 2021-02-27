using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampData
{
    [Table("Players")]
    public class Player
    {
        public int Id { get; set; }



        public int TeamId { get; set; }
        // oyuncunun 1 tane takımı olur
        public virtual Team Team { get; set; }


        [Required]
        public string PlayerName { get; set; }


        public override string ToString()
        {
            return PlayerName;
        }

    }
}
