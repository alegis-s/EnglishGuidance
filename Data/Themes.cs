using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EnglishGuidance.Data
{
    public class Themes
    {
        [Key]
        public int ThemeId { get; set; }
        public string ThemeName { get; set; }
    }
}
