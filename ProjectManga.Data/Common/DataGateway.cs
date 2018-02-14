namespace ProjectManga.Data.Common
{
    using System.Data;

    /// <summary>
    /// Represents gateways base class.
    /// </summary>
    public abstract class DataGateway
    {
        /// <summary>
        /// Constructs the gateway
        /// </summary>
        /// <param name="connection">Db connection</param>
        protected DataGateway(IDbConnection connection)
        {
            Connection = connection;
        }

        /// <summary>
        /// Gets gateway db connection
        /// </summary>
        /// <returns></returns>
        protected IDbConnection Connection { get; }

        /// <summary>
        /// Casts gateway db connection to T.
        /// </summary>
        /// <returns></returns>
        protected T ConnectionAs<T>() 
            where T : class, IDbConnection
        { 
            return Connection as T;
        }
    }
}