using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace phonebook.Models
{
    public class ContactsClass
    {
        [PrimaryKey, AutoIncrement]
        public int serial { get; set; }

        [MaxLength(5)]
        public string title { get; set; }

        [MaxLength(50)]
        public string fullname { get; set; }


        [MaxLength(50)]
        public string ph1type{ get; set; }

        [MaxLength(15)]
        public string ph1 { get; set; }

        [MaxLength(50)]
        public string ph2type { get; set; }

        [MaxLength(15)]
        public string ph2 { get; set; }

        [MaxLength(50)]
        public string email { get; set; }

        public DateTime dob { get; set; }



    }
}
