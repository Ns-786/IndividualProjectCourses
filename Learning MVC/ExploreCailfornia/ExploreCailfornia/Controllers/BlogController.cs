﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCailfornia.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }


        [Route(@"{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            var post = new Post
            {
                Title = "My blog post",
                Posted = DateTime.Now,
                Author = "Jess Chadwick",
                Body = "This is a great blog post, don't you think?",

            };

            return View(post);
        }
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet, Route("create")]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost, Route("create")]
        public IActionResult Create([Bind("Title","Body")]Post post)
        {
            if (ModelState.IsValid)
            post.Author = User.Identity.Name;
            post.Posted = DateTime.Now;
            return View();
        }
        
          

    }
}



