﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.CarResults
{
    public class GetCarByIdQueryResult
    {
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int Km { get; set; }
        public int CarTransmissionID { get; set; }
        public byte Seat { get; set; }
        public int CarLuggageID { get; set; }
        public int CarFuelID { get; set; }
        public string BigImageUrl { get; set; }
    }
}