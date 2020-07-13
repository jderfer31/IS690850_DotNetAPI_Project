using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class UsersDTO
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FullAddress { get; set; }
    }
}
