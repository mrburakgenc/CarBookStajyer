﻿namespace CarBook.Application.Features.CQRS.Results.ServiceResults
{
	public class GetServiceByIdQueryResult
	{
		public int ServiceID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string IconUrl { get; set; }
	}
}
