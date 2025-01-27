﻿using CarBook.Application.Features.CQRS.Queries.ServiceQueries;
using CarBook.Application.Features.CQRS.Results.ServiceResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.CQRS.Handlers.ServiceHandlers
{
	public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
	{
		private readonly IRepository<Service> _repository;

		public GetServiceByIdQueryHandler(IRepository<Service> repository)
		{
			_repository = repository;
		}

		public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			return new GetServiceByIdQueryResult
			{
				ServiceID = values.ServiceID,
				IconUrl = values.IconUrl,
				Title = values.Title,
				Description = values.Description

			};
		}
	}
}
