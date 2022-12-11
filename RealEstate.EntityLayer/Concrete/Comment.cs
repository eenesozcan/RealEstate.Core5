using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string NameSurname { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }

        //05.12.2022 ders 1:19:02 'den itibaren uygulanacak
    }
}
