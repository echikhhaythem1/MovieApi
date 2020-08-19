using MyDBM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDBM.Data.EFCore
{
        public class EfCoreStarRepository : EfCoreRepository<Star, MyDBMContext>
        {
            public EfCoreStarRepository(MyDBMContext context) : base(context)
            {

            }
        }
    }

