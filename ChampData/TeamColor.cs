using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampData
{
    [Table("TeamColors")]
    public class TeamColor
    {
        [ForeignKey("Color")]
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }


        [Required]
        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }


        public override string ToString()
        {
            return Color.ColorName;
        }
    }
}
