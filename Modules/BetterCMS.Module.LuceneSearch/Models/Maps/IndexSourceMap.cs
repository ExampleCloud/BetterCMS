﻿using BetterCms.Core.Models;
using BetterCms.Module.LuceneSearch;

namespace BetterCMS.Module.LuceneSearch.Models.Maps
{
    public class IndexSourceMap : EntityMapBase<IndexSource>
    {
        public IndexSourceMap()
            : base(LuceneSearchModuleDescriptor.ModuleName)
        {
            Table("IndexSources");

            Map(x => x.SourceId).Not.Nullable();
            Map(x => x.Path).Not.Nullable();
            Map(x => x.StartTime).Nullable();
            Map(x => x.EndTime).Nullable();
        }
    }
}
