﻿using CarBook.Application.Features.CQRS.Queries.FuelQueries;
using CarBook.Application.Features.CQRS.Results.FuelResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.FuelHandlers
{
    public class GetFuelQueryHandler : IRequestHandler<GetFuelQuery, List<GetFuelQueryResult>>
    {
        private readonly IRepository<CarFuel> _repository;

        public GetFuelQueryHandler(IRepository<CarFuel> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFuelQueryResult>> Handle(GetFuelQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFuelQueryResult
            {
                CarFuelID = x.CarFuelID,
                FuelType = x.FuelType,
            }).ToList();
        }
    }
}
