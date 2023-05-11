using MediatR;
using MovieMangament.Library.Commands;
using MovieMangament.Library.Data;
using MovieMangament.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMangament.Library.Handlers
{
    public class AddMovieCommandHandler : IRequestHandler<AddMovieCommand, MovieModel>
    {
        private readonly IDataRepository _datarepository;
        public AddMovieCommandHandler(IDataRepository dataRepository)
        {
            _datarepository = dataRepository;

        }
        public  Task<MovieModel> Handle(AddMovieCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_datarepository.AddMovie(request.model)); 
        }
    }
}
