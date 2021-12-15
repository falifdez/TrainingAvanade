using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;

namespace Training.Application.Users
{
    public class UserDto
    {
        public string dni { get; set; }

        public string Name { get; set; }

        public User GetEntity()
        {
            return new User
            {
                Dni = this.dni,
                Name = this.Name
            };
        }

        public static UserDto GetDtoByEntity(User dto)
        {
            return new UserDto
            {
                dni = dto.Dni,
                Name = dto.Name,

            };
        }
    }
}
