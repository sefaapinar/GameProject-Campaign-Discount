using GameProject.Entities;
using GameProject.Abstrct;
using GameProject.Conret;
using KimlikBilgisi;
using System;
using System.Collections.Generic;
using System.Text;


namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IUserValidation
    {
        public bool Validate(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
         (new TCKimlikNoDogrulaRequest
         (new TCKimlikNoDogrulaRequestBody(user.IdentityNumber,
         user.FirstName.ToUpper(), user.LastName.ToUpper(), user.BirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
