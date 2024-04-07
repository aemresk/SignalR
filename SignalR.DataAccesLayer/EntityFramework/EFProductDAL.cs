using SignalR.DataAccesLayer.Abstract;
using SignalR.DataAccesLayer.Concrete;
using SignalR.DataAccesLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccesLayer.EntityFramework
{
    public class EFProductDAL : GenericRepository<Product>, IProductDAL
    {
        public EFProductDAL(SignalRContext context) : base(context)
        {
        }
    }
}
