using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCalendar.Models
{
    public class KoreseddelModel
    {
		[Key]
		public int KoreseddelModelId { get; set; }

		[Required]
        public string Bruger { get; set; }

        [Required]
        public string Formal { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDato { get; set; } = DateTime.Today;

        [Required]
        [DataType(DataType.Date)]
        public DateTime SlutDato { get; set; } = DateTime.Today;

        [Required]
        public int KmStart { get; set; }

        [Required]
        public int KmSlut { get; set; }

        [Required]
        public string FraDestination { get; set; }

        [Required]
        public string TilDestination { get; set; }
        
        [Required]
        public string BilId { get; set; }

        public int KmKort => KmSlut - KmStart;
    }
}
