using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ExamQuestions
{
    public class DataAccessComponent_ImplicitInterface : IDisposable
    {
        public class TestObjects
        {
            public bool TestAll()
            {
                var daII = new DataAccessComponent_ImplicitInterface();

                daII.Dispose();

                return true;
            }
        }
        private System.Data.SqlClient.SqlConnection dbConn;

        public DataAccessComponent_ImplicitInterface()
        {
            dbConn = new System.Data.SqlClient.SqlConnection();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    dbConn.Dispose();
                    //dbConn.Close();
                    //dbConn = null;
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        //~DataAccessComponent_ImplicitInterface()
        //{
        //    // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //    Dispose(false);
        //}

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

        //~DataAccessComponent()
        //{
        //    dbConn.Close();
        //    dbConn = null;
        //}
    }

    public class DataAccessComponent_ExplicitInterface : IDisposable
    {
        public class TestObjects
        {
            public bool TestAll()
            {
                var daEI = new DataAccessComponent_ExplicitInterface();

                ((IDisposable)daEI).Dispose();

                IDisposable id = daEI;
                id.Dispose();

                return true;
            }
        }

        private System.Data.SqlClient.SqlConnection dbConn;

        public DataAccessComponent_ExplicitInterface()
        {
            dbConn = new System.Data.SqlClient.SqlConnection();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    dbConn.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~DataAccessComponent_ExplicitInterface() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

        //~DataAccessComponent()
        //{
        //    dbConn.Close();
        //    dbConn = null;
        //}
    }

}

public interface IDoSomething
    {
        bool IsDone();
        void DoSomething();
    }

    public abstract class myAbstractClass 
    {
        public void ImplementedFucntion()
        {

        }

    }


}
