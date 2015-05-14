using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IEntityDataProvider<T>
    {
        IList<T> GetAll();

        T GetById(string id);

        void AddT(T element);

        void DeleteT(string id);
    }
}
