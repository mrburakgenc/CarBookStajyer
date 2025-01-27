﻿using CarBook.Dto.BlogDtos;
using CarBook.Dto.TagCloudDtos;
using CarBook.WebUI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Areas.Site.ViewComponents.BlogViewComponents
{
    public class _BlogDetailCloudTagByBlogComponentPartial : ViewComponent
    {
        private readonly IApiService<ResultGetTagCloudByIdDto> _apiService;

        public _BlogDetailCloudTagByBlogComponentPartial(IApiService<ResultGetTagCloudByIdDto> apiService)
        {
            _apiService = apiService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.BlogID = id;
            var values = await _apiService.GetListAsync($"TagClouds/GetTagCloudByBlogId/{id}");
            return View(values);
        }
    }
}
