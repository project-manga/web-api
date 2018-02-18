namespace ProjectManga.Domain.Download.Vos
{
    using System;
    using ProjectManga.Domain.Common.Vos;
    
    /// <summary>
    /// Represents download request entity id.
    /// </summary>
    public class DownloadRequestId : ValueObject<DownloadRequestId>, IEquatable<DownloadRequestId>
    {
        public DownloadRequestId(long id) 
        {
            Id = id;
        }

        /// <summary>
        /// Gets id.
        /// </summary>
        /// <returns></returns>
        public long Id { get; }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        protected override bool DeepEquals(DownloadRequestId other)
        {
            return Id == other.Id;
        }
    }
}