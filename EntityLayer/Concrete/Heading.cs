using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }

        [StringLength(100)]
        public string HeadingName { get; set; }
       

        public DateTime HeadingTime { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<Content> Contets { get; set; }
        ///
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
