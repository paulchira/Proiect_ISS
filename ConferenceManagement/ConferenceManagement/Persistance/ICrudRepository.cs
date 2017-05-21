using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Persistance
{
    public interface ICrudRepository<E>
    {
        E findOne(int id);
        IEnumerable<E> getAll();
        void add(E entity);
        void update(E oldV, E newV);
        void delete(int id);
    }
}
