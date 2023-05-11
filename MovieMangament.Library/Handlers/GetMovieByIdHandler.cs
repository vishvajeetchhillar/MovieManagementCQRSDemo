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
    public class GetMovieByIdHandler : IRequestHandler<GetMovieByIdQuery, MovieModel>
    {
        private readonly IMediator _mediator;
        public GetMovieByIdHandler(IMediator mediator)
        {
            _mediator=mediator;

        }
        public async Task<MovieModel> Handle(GetMovieByIdQuery request, CancellationToken cancellationToken)
        {
            var movies = await _mediator.Send(new GetMovieListQuery());
            var movie = movies.FirstOrDefault(u => u.Id == request.id);
            return movie;

            
        }
    }
}
