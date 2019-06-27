﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext storeDB = new ApplicationDbContext();
        //
        // GET: /Home/
        public ActionResult Index()
        {
            // Get most popular albums
            var albums = GetTopSellingAlbums(5);
            return View(albums);
        }
        public List<Album> GetTopSellingAlbums(int count)
        {
            // Group the order details by album and return
            // the albums with the highest count
            return storeDB.Albums
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }



    }
}