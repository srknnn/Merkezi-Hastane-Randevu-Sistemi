using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    interface IDataUserMapper<TEntity,TKey>
    {
        TEntity GetLogin(TKey id);
        List<TEntity> GetUserALL();
    }
}
