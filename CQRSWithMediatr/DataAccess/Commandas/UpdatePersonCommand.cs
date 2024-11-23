using DataAccess.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Commandas
{
    public record UpdatePersonCommand(PersonModel Person) : IRequest<PersonModel>; 

    //public class UpdatePersonClass
    //{
    //    public PersonModel Person { get; set; }
    //    public UpdatePersonClass(PersonModel person)
    //    {
    //        Person = person;
    //    }
    //}
}
