﻿using CarBook.Application.Features.CQRS.Commands.CategoryCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.CQRS.Handlers.CategoryHandlers
{
	public class UpdateCategoryCommandHandler:IRequestHandler<UpdateCategoryCommand>
	{
		private readonly IRepository<Category> _repository;

		public UpdateCategoryCommandHandler(IRepository<Category> repository)
		{
			_repository = repository;
		}


        public async Task Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.CategoryID);
            values.Name = request.Name;
            await _repository.UpdateAsync(values);
        }
    }
}
