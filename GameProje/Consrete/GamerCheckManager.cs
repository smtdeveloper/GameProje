using GameProje.Abstract;
using GameProje.Adapter;
using GameProje.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Consrete
{
    class GamerCheckManager : IGamerCheckManager
    {
        IGamerCheckManager _gamerCheckService;
        public bool Check(Gamer gamer)
        {
            _gamerCheckService = new MernisServiceAdapter();

            return _gamerCheckService.Check(gamer);
        }
    }
}
