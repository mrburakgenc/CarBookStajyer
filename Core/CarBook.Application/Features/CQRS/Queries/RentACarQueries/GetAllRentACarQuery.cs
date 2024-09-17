﻿using CarBook.Application.Features.CQRS.Results.RentACarResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.RentACarQueries
{
    public class GetAllRentACarQuery:IRequest<List<GetAllRentACarQueryResult>>
    {
    }
}