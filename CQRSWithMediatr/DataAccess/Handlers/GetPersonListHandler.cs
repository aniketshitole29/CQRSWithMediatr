using DataAccess.DataAccess;
using DataAccess.Model;
using DataAccess.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
    {
        private readonly IDataAccess _data;
        public GetPersonListHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetPeople());
        }
    }
}
