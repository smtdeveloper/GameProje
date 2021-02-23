using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Entity
{
    class Gamer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public long NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
