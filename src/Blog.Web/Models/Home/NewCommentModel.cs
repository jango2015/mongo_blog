﻿using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Blog.Web.Models.Home
{
    public class NewCommentModel
    {
        [HiddenInput(DisplayValue = false)]
        public string PostId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Content { get; set; }
    }
}