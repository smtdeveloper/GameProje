using GameProje.Abstract;
using GameProje.Entity;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Adapter
{
    class MernisServiceAdapter : IGamerCheckManager
    {
        public bool Check(Gamer gamer)
        {
              KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(
                    Convert.ToInt64(
                    gamer.NationalityId),
                    gamer.FirstName.ToUpper(),
                    gamer.LastName.ToUpper(),
                    gamer.DateOfBirth.Year)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
