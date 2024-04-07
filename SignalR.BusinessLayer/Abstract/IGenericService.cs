using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        // başta T olanlar GEneric SERVICE
        void TAdd(T entity);
        void TDelete(T entity);
        void TUpdate(T entity);

        T TGetByID(int id);
        List<T> TGetListAll();
    }
}
