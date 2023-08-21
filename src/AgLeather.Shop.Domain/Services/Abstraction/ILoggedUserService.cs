using AgLeather.Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Domain.Services.Abstraction
{
    public interface ILoggedUserService
    {
        int? UserId { get; }
        Roles? Role { get; }
        string Username { get; }
        string Email { get; }
    }
}
