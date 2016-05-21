using System.Collections.Generic;
using AutoMapper;

namespace SpineX.DataAdapter
{
    public class DataAdapterHelper
    {

        /// <summary>
        /// Copies one entity to another using AutoMapper
        /// </summary>
        /// <typeparam name="SourceType"></typeparam>
        /// <typeparam name="DestType"></typeparam>
        /// <param name="from">source </param>
        /// <returns> destination type </returns>
        public static DestType CopyFrom<SourceType, DestType>(SourceType from)
            where DestType : class, new()
            where SourceType : class, new()
        {
            DestType result = null;
            if (from != null)
            {
                Mapper.CreateMap<SourceType, DestType>();
                result = Mapper.Map<SourceType, DestType>(from);
            }
            return result;
        }

        /// <summary>
        /// Copies one List of entities to another list using AutoMapper
        /// </summary>
        /// <typeparam name="SourceType"></typeparam>
        /// <typeparam name="DestType"></typeparam>
        /// <param name="from">source </param>
        /// <returns> destination type </returns>
        public static IList<DestType> CopyFrom<SourceType, DestType>(IList<SourceType> fromList)
            where DestType : class, new()
            where SourceType : class, new()
        {
            IList<DestType> result = null;
            if (fromList != null && fromList.Count > 0)
            {
                Mapper.CreateMap<SourceType, DestType>();
                result = Mapper.Map<IList<SourceType>, IList<DestType>>(fromList);
            }
            return result;
        }
    }
}
