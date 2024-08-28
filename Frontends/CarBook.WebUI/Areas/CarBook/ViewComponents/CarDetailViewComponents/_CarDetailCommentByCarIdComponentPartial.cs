﻿using CarBook.Dto.CarDtos;
using CarBook.Dto.ReviewDtos;
using CarBook.WebUI.Areas.CarBook.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Areas.Site.ViewComponents.CarDetailViewComponents
{
    public class _CarDetailCommentByCarIdComponentPartial : ViewComponent
    {
        private readonly IApiCarBookService<ResultReviewsByCarIDDto> _apiService;

        public _CarDetailCommentByCarIdComponentPartial(IApiCarBookService<ResultReviewsByCarIDDto> apiService)
        {
            _apiService = apiService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.carid = id;
            var values = await _apiService.GetListAsync($"https://localhost:7278/api/Reviews/GetReviewsByCarIdQuery/{id}");
            return View(values);
        }
    }
}
