﻿using Entities.Newses;
using System;
using WebFramework.Api;

namespace MyApi.Models
{
    public class NewsDto : BaseDto<NewsDto, News>
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
