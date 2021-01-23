﻿using SQLite;

namespace EvernoteClone.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
