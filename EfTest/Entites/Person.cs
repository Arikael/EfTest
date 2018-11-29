using EfTest.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfTest.Entites
{
    public class Person : Base
    {
        [StringLength(80)]
        [Required]
        public string Name { set; get; }
        public Sex Sex { set; get; }

        public string SozialVersicherungsNr { set; get; }

        public DateTime Birthday { set; get; }
       
        public virtual Company Company { set; get; }
    }
}
