using DataAccess.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    public record GetPersonByIdQuery(int id) : IRequest<PersonModel>;

    //public class GetPersonByIdQueryClass : IRequest<PersonModel>
    //{
    //public int id { get; set; }
    //public GetPersonByIdQueryClass(int ID)
    //{
    //    id = ID;
    //}
    //}
}
