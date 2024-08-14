﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.BlogDtos
{
    public class ResultGetAllBlogsWithAuthorsDto
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CoverImageUrl { get; set; }
        public string AuthorImageUrl { get; set; }
        public string AuthorDescription { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
