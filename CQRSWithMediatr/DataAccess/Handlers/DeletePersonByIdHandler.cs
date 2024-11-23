using DataAccess.DataAccess;
using DemoLibrary.Commandas;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class DeletePersonByIdHandler : IRequestHandler<DeletePersonByIdCommand, bool>
    {
        public IDataAccess _data { get; set; }

        public DeletePersonByIdHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<bool> Handle(DeletePersonByIdCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.DeletePersonById(request.id));
        }
    }
}
