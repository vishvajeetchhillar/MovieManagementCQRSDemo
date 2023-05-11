using MediatR;
using MediatR.Pipeline;
using MovieMangament.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMangament.Library.Queries
{
    public record GetMovieByIdQuery(int id):IRequest<MovieModel>;
}
