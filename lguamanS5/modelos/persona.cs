using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace lguamanS5.modelos
{
    [SQLite.Table("persona")]
    public class persona
    {
        [PrimaryKey, AutoIncrement]

        public int Id   { get; set; }

        [MaxLength(25)]
        public string Name { get; set; }


    }
}
