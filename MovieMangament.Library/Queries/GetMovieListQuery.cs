using MediatR;
using MovieMangament.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMangament.Library.Queries
{
    
    public record GetMovieListQuery:IRequest<List<MovieModel>>;
}
