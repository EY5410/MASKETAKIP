using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Business.Abstract;
using WinFormsApp2.Entities;

namespace WinFormsApp2.Business.Concert
{
    internal class PersonManager : IApplicantService
    {
        List<Person> persons=new();
       
        public bool MaskControl(Person person)
        {
            for(int i=0;i<persons.Count;i++)
            {
                if (person.NationalIdentity == persons[i].NationalIdentity)
                {
                    return false;
                }
            }
            persons.Add(person);
            return true;
        }

        public bool PersonControl(Person person)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;


        }
    }
}
