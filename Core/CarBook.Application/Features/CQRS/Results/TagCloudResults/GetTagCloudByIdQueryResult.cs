﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Results.TagCloudResults
{
    public class GetTagCloudByIdQueryResult
    {
        public int TagCloudId { get; set; }
        public string Title { get; set; }
        public int BlogID { get; set; }
    }
}