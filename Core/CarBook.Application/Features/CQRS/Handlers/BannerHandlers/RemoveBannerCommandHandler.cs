﻿using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
	public class RemoveBannerCommandHandler:IRequestHandler<RemoveBannerCommand>
	{
		private readonly IRepository<Banner> _repository;
		public RemoveBannerCommandHandler(IRepository<Banner> repository)
		{
			_repository = repository;
		}
		public async Task Handle(RemoveBannerCommand request, CancellationToken cancellationToken)
        {
			var value = await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(value);
		}
    }
}
