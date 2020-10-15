using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LyricsStats.Models
{
    public class SearchModel
    {
        [Required]
        [RegularExpression(@"^[^\\/]*$")]
        public string ArtistName { get; set; }
    }
}
