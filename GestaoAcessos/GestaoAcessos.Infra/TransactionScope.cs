using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Infrastructure
{
    public sealed class TransactionScope : IDisposable
    {
        private ISession _session;
        private bool _wasCommited;

        public TransactionScope(ISession pSession)
        {
            _session = pSession;
            _session.Transaction.Begin();
        }

        /// <summary>
        /// Commits this instance.
        /// </summary>
        public void Commit()
        {
            if (_session == null) return;
            _session.Transaction.Commit();
            _wasCommited = true;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (_session == null) return;
            if (!_wasCommited)
                _session.Transaction.Rollback();
            _session.Close();
        }
    }
}
