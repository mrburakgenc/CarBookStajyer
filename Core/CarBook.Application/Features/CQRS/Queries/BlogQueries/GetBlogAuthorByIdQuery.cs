﻿using CarBook.Application.Features.CQRS.Results.BlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.BlogQueries
{
    public class GetBlogAuthorByIdQuery:IRequest<List<GetBlogAuthorByIdQueryResult>>
    {
        public int Id { get; set; }

        public GetBlogAuthorByIdQuery(int id)
        {
            Id = id;
        }
    }
}
