using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    interface IBusinessUserLogin<TEntity,TKey>
    {

        TEntity GetUserLogin(TKey id);
        List<TEntity>GetUserALL();
    }
}
