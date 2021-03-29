using System;
using SQLite;

namespace XamEssentialsApp.Models
{
    public class MainMenuItem
    {
        [PrimaryKey]
         
        public int ID { get; set; }
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
    }
}
