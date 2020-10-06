using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionBD.Domain
{
    public class ListResponseModel<TModel> : IListResponseModel<TModel>
    {

        public int Index { set; get; }
        public int Count { set; get; }
        public int TotalCount { set; get; }
        public IEnumerable<TModel> Model { get; set; }
    }
    public class SingleResponseModel<TModel> : ISingleResponseModel<TModel>
    {
        public TModel Model { get; set; }
    }
    public interface ISingleResponseModel<TModel>
    {
        TModel Model { get; set; }
    }

    public interface IListResponseModel<TModel>
    {
        IEnumerable<TModel> Model { get; set; }
    }
}
