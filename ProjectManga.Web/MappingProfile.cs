namespace ProjectManga.Web
{
    using Domain.Models;
    using Domain.Vos;
    using Resources;
    using System.Linq;

    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            // From domain to resource
            CreateMap<DownloadRequest, DownloadRequestResource>()
                .ForMember(drr => drr.CreatedOn, opt => opt.MapFrom(dr => dr.CreationDateTime))
                .ForMember(drr => drr.ModifiedOn, opt => opt.MapFrom(dr => dr.ModificationDateTime));

            CreateMap<DownloadRequest, SaveDownloadRequestResource>();
            CreateMap<QueryResult<DownloadRequest>, QueryResultResource<DownloadRequestResource>>();

            // From resource to domain
            CreateMap<SaveDownloadRequestResource, DownloadRequest>();
            CreateMap<DownloadRequestQueryResource, DownloadRequestQuery>();

        }
    }
}