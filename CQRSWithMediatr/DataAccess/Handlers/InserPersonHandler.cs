using DataAccess.DataAccess;
using DataAccess.Model;
using DemoLibrary.Commandas;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class InserPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
    {
        private readonly IDataAccess _data;

        public InserPersonHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.InsertPerson(request.FirstName, request.LastName));
        }
    }
}
