using DataAccess.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Commandas
{
    public record DeletePersonByIdCommand(int id) : IRequest<bool>;

    //public class DeletePersonById : IRequest<bool>
    //{
    //public int id { get; set; }
    //public DeletePersonById(int ID)
    //{
    //    id = ID;
    //}
    //}
}
