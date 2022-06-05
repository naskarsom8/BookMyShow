﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookMyShow.Models;
using BookMyShow.ViewModels;

namespace BookMyShow.Controllers
{
    public class MoviesController : Controller
    {
        ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies/Random
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre);
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movies = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            return View(movies);
        }

    }
}