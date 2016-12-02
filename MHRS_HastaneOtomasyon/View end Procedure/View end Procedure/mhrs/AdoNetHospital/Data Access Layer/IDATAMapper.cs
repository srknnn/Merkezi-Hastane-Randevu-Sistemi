using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    interface IDATAMapper<TEntity, TKey>
    {
        int Insert(TEntity item);

        int Update(TEntity item);

        int Delete(TEntity item);

        List<TEntity> GelAll();

        TEntity Get(TKey id);



    }
}
