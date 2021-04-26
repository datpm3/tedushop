using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class PostTagViewModel
    {
        public int PostID { set; get; }
        
        public string TagID { set; get; }
        
        public virtual PostViewModel Post { set; get; }
        
        public virtual TagViewModel Tag { set; get; }

        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { set; get; }

        public DateTime? UpdateDate { set; get; }

        public string UpdateBy { set; get; }

        public string MetaKeywork { set; get; }

        public string MetaDescription { set; get; }

        public bool Status { set; get; }
    }
}