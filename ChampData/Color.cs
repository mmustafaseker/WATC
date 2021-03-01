using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampData
{
    [Table("Colors")]
    public class Color
    {
        public int Id { get; set; }

        [Required]
        public string ColorName { get; set; }


        [Required]
        [Range(0, 255)]
        public string Red { get; set; }

        [Required]
        [Range(0, 255)]
        public string Green { get; set; }


        [Required]
        [Range(0, 255)]
        public string BLue { get; set; }

        public virtual ICollection<Team> Teams { get; set; }

        public override string ToString()
        {
            return ColorName;
        }
    }
}
