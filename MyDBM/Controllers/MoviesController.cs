using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyDBM.Data.EFCore;
using MyDBM.Models;

namespace MyDBM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : MyMDBController<Movie, EfCoreMovieRepository>
    {
        public MoviesController(EfCoreMovieRepository repository) : base(repository)
        {

        }
    }
}

