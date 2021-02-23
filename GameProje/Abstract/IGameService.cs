using GameProje.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
