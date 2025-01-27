﻿using CarBook.Application.Features.CQRS.Queries.FooterAddressQueries;
using CarBook.Application.Features.CQRS.Results.FooterAddressResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.CQRS.Handlers.FooterAddressHandlers
{
	public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>
	{
		private readonly IRepository<FooterAddress> _repository;

		public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return values.Select(x => new GetFooterAddressQueryResult
			{
				FooterAddressID = x.FooterAddressID,
				Address = x.Address,
				Description = x.Description,
				Email = x.Email,
				Phone = x.Phone,
			}).ToList();
		}
	}
}
