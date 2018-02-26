namespace ProjectManga.Web
{
    using Domain.Download.Models;
    using Domain.Download.Vos;
    using ProjectManga.Domain.Common.Vos;
    using Resources;
    using System.Linq;

    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            // From domain to resource
            CreateMap<DownloadRequest, DownloadRequestResource>();

            CreateMap<DownloadRequest, SaveDownloadRequestResource>();
            CreateMap<QueryResult<DownloadRequest>, QueryResultResource<DownloadRequestResource>>();

            // From resource to domain
            CreateMap<SaveDownloadRequestResource, DownloadRequest>();
            CreateMap<DownloadRequestQueryResource, DownloadRequestQuery>();

        }
    }
}