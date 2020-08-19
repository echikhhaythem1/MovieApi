using MyDBM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDBM.Data.EFCore
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, MyDBMContext>
    {
        public EfCoreMovieRepository(MyDBMContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
