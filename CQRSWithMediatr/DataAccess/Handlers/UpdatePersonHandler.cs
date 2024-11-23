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
    public class UpdatePersonHandler : IRequestHandler<UpdatePersonCommand, PersonModel>
    {
        public IDataAccess _data { get; set; }

        public UpdatePersonHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<PersonModel> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.UpdatePerson(request.Person));
        }
    }
}
