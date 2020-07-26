using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EnglishGuidance.Data;

namespace EnglishGuidance
{
    class DBConInitializer : CreateDatabaseIfNotExists<DBCon>
    {
        protected override void Seed(DBCon db)
        {
            Users u1 = new Users { UserName = "Sagitov", UserGroup = "29" };
            Themes t1 = new Themes { ThemeId = 1, ThemeName = "Numbers" };
            Themes t2 = new Themes { ThemeId = 2, ThemeName = "Measurements" };
            Themes t3 = new Themes { ThemeId = 3, ThemeName = "Power Tools" };
            Themes t4 = new Themes { ThemeId = 4, ThemeName = "Tools" };
            Themes t5 = new Themes { ThemeId = 5, ThemeName = "Materials" };
            Themes t6 = new Themes { ThemeId = 6, ThemeName = "Elements" };
            Themes t7 = new Themes { ThemeId = 7, ThemeName = "Safety" };
            Themes t8 = new Themes { ThemeId = 8, ThemeName = "Wires" };
            Themes t9 = new Themes { ThemeId = 9, ThemeName = "Actions" };
            db.Users.Add(u1);
            db.Themes.Add(t1);
            db.Themes.Add(t2);
            db.Themes.Add(t3);
            db.Themes.Add(t4);
            db.Themes.Add(t5);
            db.Themes.Add(t6);
            db.Themes.Add(t7);
            db.Themes.Add(t8); 
            db.Themes.Add(t9);
            db.SaveChanges();
        }
    }
}
