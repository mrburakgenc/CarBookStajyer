﻿using MediatR;

namespace CarBook.Application.Features.CQRS.Commands.BrandCommands
{
	public class RemoveBrandCommand : IRequest
    {
		public int Id { get; set; }

		public RemoveBrandCommand(int id)
		{
			Id = id;
		}
	}
}
