using MediatR;
using MovieMangament.Library.Data;
using MovieMangament.Library.Models;
using MovieMangament.Library.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMangament.Library.Handlers
{

    public class GetMovieListHandler : IRequestHandler<GetMovieListQuery, List<MovieModel>>
    {
        private readonly IDataRepository _datarepository;
        public GetMovieListHandler(IDataRepository dataRepository)
        {
            _datarepository= dataRepository;
            
        }
        public Task<List<MovieModel>> Handle(GetMovieListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_datarepository.GetMovies());
        }
    }
}
