using DataAccsessLayer.Abstruct;
using DataAccsessLayer.Repository;
using EntityLayer.Contrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Contrete.EntityFramework
{
  public  class EfAboutRepository :GenericRepository<About>,IAboutDal
    {
    }
}
