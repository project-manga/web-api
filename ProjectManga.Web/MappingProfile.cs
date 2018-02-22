namespace ProjectManga.Web
{
    using ProjectManga.Domain.Download.Models;
    using ProjectManga.Web.Resources;
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            // From domain to resource
            CreateMap<DownloadRequest, DownloadRequestResource>();
            CreateMap<DownloadRequest, CreateDownloadRequestResource>();

            // From resource to domain
            CreateMap<CreateDownloadRequestResource, DownloadRequest>();
        }
    }
}