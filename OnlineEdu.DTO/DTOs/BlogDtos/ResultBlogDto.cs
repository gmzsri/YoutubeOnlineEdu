﻿using OnlineEdu.DTO.DTOs.BlogCategoryDtos;
using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DTO.DTOs.BlogDtos
{
    public class ResultBlogDto
    {
        public int BlogId { get; set; }
        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public string Content { get; set; }

        public string BlogDate { get; set; }

        public int BlogCategoryId { get; set; } //blog ile blog kategori arasında bağlantı olmasını sağlama amaclı yapıldı

        public ResultBlogCategoryDto BlogCategory { get; set; }
    }
}
 