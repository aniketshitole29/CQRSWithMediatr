using DataAccess.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;

    //public class GetPersonListQueryClass : IRequest<List<PersonModel>>
    //{
    //}
}
