using Microsoft.AspNetCore.Mvc;
using MyDBM.Data.EFCore;
using MyDBM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDBM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarsController : MyMDBController<Star, EfCoreStarRepository>
    {
        public StarsController(EfCoreStarRepository repository) : base(repository)
        {

        }
    }
}
