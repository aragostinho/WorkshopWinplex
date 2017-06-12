using GestaoAcessos.Infra;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Business.Core
{
    public abstract class AbstractGenericDao<T> : IGenericDao<T> where T : class
    {


        protected ISession _ISession;
        public AbstractGenericDao()
        {
            _ISession = InitializeSession;
        }


        public AbstractGenericDao(ISession pSession)
        {
            _ISession = pSession;
        }

        protected ISession InitializeSession
        {
            get
            {
                return FluentNHibernateHelper.GetSession;
            }

        }


        public virtual void Save(T pObject, bool isUsingTransaction = false)
        {
            if (_ISession == null)
                throw new Exception("Não foi possível conectar no banco de dados");

            try
            {
                if (!isUsingTransaction)
                    _ISession.BeginTransaction();

                _ISession.Save(pObject);

                if (!isUsingTransaction)
                    _ISession.Transaction.Commit();

            }
            catch (Exception oException)
            {

                if (!isUsingTransaction)
                    _ISession.Transaction.Rollback();

                throw oException;
            }

        }


        public virtual void Update(T pObject, bool isUsingTransaction = false)
        {
            if (_ISession == null)
                throw new Exception("Não foi possível conectar no banco de dados");

            try
            {
                if (!isUsingTransaction)
                    _ISession.BeginTransaction();

                _ISession.Update(pObject);

                if (!isUsingTransaction)
                    _ISession.Transaction.Commit();

            }
            catch (Exception oException)
            {

                if (!isUsingTransaction)
                    _ISession.Transaction.Rollback();

                throw oException;
            }


        }
        public virtual void Delete(T pObject, bool isUsingTransaction = false)
        {

            if (_ISession == null)
                throw new Exception("Não foi possível conectar no banco de dados");

            try
            {
                if (!isUsingTransaction)
                    _ISession.BeginTransaction();

                _ISession.Delete(pObject);

                if (!isUsingTransaction)
                    _ISession.Transaction.Commit();

            }
            catch (Exception oException)
            {

                if (!isUsingTransaction)
                    _ISession.Transaction.Rollback();

                throw oException;
            }

        }


        public virtual IList<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> pLinqExpression)
        {
            if (_ISession == null)
                throw new Exception("Não foi possível conectar no banco de dados");

            try
            {
                IList<T> objectList = _ISession.QueryOver<T>().Where(pLinqExpression).List<T>();
                return objectList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public virtual IList<T> List()
        {
            if (_ISession == null)
                throw new Exception("Não foi possível conectar no banco de dados");

            try
            {
                IList<T> objectList = _ISession.QueryOver<T>().List<T>();
                return objectList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
