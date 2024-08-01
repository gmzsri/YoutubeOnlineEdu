using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public string Content { get; set; }

        public string BlogDate { get; set; }

        public int BlogCategoryId { get; set; } //blog ile blog kategori arasında bağlantı olmasını sağlama amaclı yapıldı

        public BlogCategory BlogCategory { get; set; }
    }
}
