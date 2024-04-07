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
    public class EFContactDAL : GenericRepository<EFContactDAL>, IContactDAL
    {
        public EFContactDAL(SignalRContext context) : base(context)
        {
        }

        public void Add(Contact entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Contact entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact entity)
        {
            throw new NotImplementedException();
        }

        Contact IGenericDAL<Contact>.GetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<Contact> IGenericDAL<Contact>.GetListAll()
        {
            throw new NotImplementedException();
        }
    }
}
