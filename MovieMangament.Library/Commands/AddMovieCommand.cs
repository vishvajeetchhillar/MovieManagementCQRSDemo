using MediatR;
using MovieMangament.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMangament.Library.Commands
{
    public record AddMovieCommand(MovieModel model): IRequest<MovieModel>;
}
