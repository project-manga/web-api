﻿namespace ProjectManga.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Extensions;
    using Domain;
    using Domain.Models;
    using Domain.Vos;

    /// <summary>
    /// Mediates between the download request domain and its data mapping using 
    /// a collection-like interface for accessing download requests.
    /// </summary>
    public class DownloadRequestRepository : Repository, IDownloadRequestRepository
    {
        #region Constructors
        /// <summary>
        /// Constructs the repository.
        /// </summary>
        public DownloadRequestRepository(ProjectMangaDbContext context)
        {
            this.context = context;
        }
        #endregion

        #region Public
        public void Add(DownloadRequest downloadRequest)
        {
            context.DownloadRequests.Add(downloadRequest);
        }

        public void Remove(DownloadRequest downloadRequest)
        {
            context.DownloadRequests.Remove(downloadRequest);
        }

        public async Task<DownloadRequest> FindAsync(long id)
        {
            return await context
                .DownloadRequests
                .Include(dr => dr.Source)
                .SingleOrDefaultAsync(dr => dr.Id == id);
        }

        public async Task<IEnumerable<DownloadRequest>> FindAllAsync()
        {
            return await context.DownloadRequests.ToListAsync();
        }

        public async Task<QueryResult<DownloadRequest>> FindAllAsync(DownloadRequestQuery filter)
        {
            var query = context.DownloadRequests
                .Include(dr => dr.Source)
                .AsQueryable();

            if (filter.SourceId.HasValue)
            {
                // filter by source
                query = query.Where(dr => dr.Source.Id == filter.SourceId.Value);
            }

            if (!string.IsNullOrWhiteSpace(filter.Text))
            {
                // filter full text
                var toLower = filter.Text.ToLower();
                query = query.Where(dr => dr.Sid.ToLower().Contains(toLower));
                query = query.Where(dr => dr.Source.Name.ToLower().Contains(toLower));
                query = query.Where(dr => dr.Source.Description.ToLower().Contains(toLower));
            }

            var count = await query.CountAsync();
            if (count == 0)
            {
                return new QueryResult<DownloadRequest>
                {
                    Items = Enumerable.Empty<DownloadRequest>(),
                    Page = 1,
                    PageSize = filter.PageSize,
                    SortBy = filter.SortBy,
                    IsSortAscending = filter.IsSortAscending
                };
            }

            var columnsMap = new Dictionary<string, Expression<Func<DownloadRequest, object>>>()
            {
                [nameof(DownloadRequest.FromChapter).ToLower()] = dr => dr.FromChapter,
                [nameof(DownloadRequest.ToChapter).ToLower()] = dr => dr.ToChapter,
                [nameof(DownloadRequest.FromChapterPart).ToLower()] = dr => dr.FromChapterPart,
                [nameof(DownloadRequest.ToChapterPart).ToLower()] = dr => dr.ToChapterPart,
                [nameof(DownloadRequest.FromPage).ToLower()] = dr => dr.FromPage,
                [nameof(DownloadRequest.ToPage).ToLower()] = dr => dr.ToPage,
                [nameof(DownloadRequest.Id).ToLower()] = dr => dr.Id,
                [nameof(DownloadRequest.Sid).ToLower()] = dr => dr.Sid,
                [nameof(DownloadRequest.Source).ToLower()] = dr => dr.Source.Name
            };

            query = query.ApplyOrdering(filter, columnsMap);

            query = query.ApplyPaging(filter);

            var result = await query.ToListAsync();

            return new QueryResult<DownloadRequest>
            {
                Items = result,
                Page = filter.Page,
                PageSize = filter.PageSize,
                SortBy = filter.SortBy,
                IsSortAscending = filter.IsSortAscending,
                Total = count
            };
        }
        #endregion

        #region Private
        private readonly ProjectMangaDbContext context;
        #endregion
    }
}
