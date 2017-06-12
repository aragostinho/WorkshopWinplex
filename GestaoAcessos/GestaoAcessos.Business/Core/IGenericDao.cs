using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Business.Core
{
    public interface IGenericDao<T>
    {

        void Save(T pObject, bool isUsingTransaction = false);
        void Update(T pObject, bool isUsingTransaction = false);
        void Delete(T pObject, bool isUsingTransaction = false);
        IList<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> pLinqExpression);
        IList<T> List();
    }
}
