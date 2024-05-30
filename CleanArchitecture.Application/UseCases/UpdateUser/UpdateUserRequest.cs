using CleanArchitecture.Application.UseCases.CreateUser;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.UseCases.UpdateUser
{
    public sealed record UpdateUserRequest(Guid Id, String Email, String Name) : IRequest<UpdateUserResponse>;
}
