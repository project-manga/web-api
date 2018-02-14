namespace ProjectManga.Data.Download.SQLite
{
    using Dapper;
    using ProjectManga.Data.Common;
    using System.Data;

    /// <summary>
    /// Represents DownloadRequestGateway SQLite implementation.
    /// </summary>
    public class SQLiteDownloadRequestGateway : DataGateway, IDownloadRequestGateway
    {
        public SQLiteDownloadRequestGateway(IDbConnection connection)
            : base(connection)
        {

        }
        
        public void Insert(DownloadRequestRow row)
        {
            var sql = "INSERT INTO (Source, Request) VALUES (@Source, @Request)";
            Connection.Execute(sql, row);
        }
    }
}