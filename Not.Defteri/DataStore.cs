using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not.Defteri
{
    public class DataStore
    {
        public static AppUser appUser = new AppUser { Id = 1, UserName = "Admin", Password = "1234" };
        public static List<Note> Notes = new List<Note>()
        {
            new Note{ Id=1, Description="Note 1"}
        };

        public class Note
        {
            public int Id { get; set; }
            public string Description { get; set; }
        }

        public class AppUser
        {
            public string UserName { get; set; }
            public string Password { get; set; }  
            public int Id { get; set; }
        }
    }
}
