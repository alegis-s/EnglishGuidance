using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnglishGuidance.Data
{
    public class Answers
    {
        [Key]
        public int AnswerThemeId { get; set; }
        public int Theme_Corr { get; set; }
        public int Answer_Mist { get; set; }
        public int Result_Corr { get; set; }
        public int Result_Incorr { get; set; }

        public int ThemeId { get; set; }
        [ForeignKey("ThemeId")]
        public Themes Theme { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public Users User { get; set; }
    }
}
