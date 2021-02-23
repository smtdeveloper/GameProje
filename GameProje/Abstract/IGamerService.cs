using GameProje.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Abstract
{
     interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
