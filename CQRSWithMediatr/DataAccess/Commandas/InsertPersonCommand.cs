using DataAccess.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Commandas
{
    public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;
    //public class InsertPersonCommandClass
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }

    //    public InsertPersonCommand(string firstName, string lastName) 
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //    }
    //}   
}
