using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EfTest.Entites
{
    public class Company : Base
    {
        [StringLength(80)]
        [Required]
        public string CompanyName { set; get; }
        //public string Test { set; get; }
        //public decimal Narf { set; get; }


        //public DateTime Test { get; set; }

        //public virtual ICollection<AdDozent> AdDozents { set; get; } = new Collection<AdDozent>();
    }
}
