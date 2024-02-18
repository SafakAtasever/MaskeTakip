using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PharmacyManager : ISupplierService
    {
        private IApplicantService _service;
        public PharmacyManager(IApplicantService service)
        {
            _service = service;
        }
        public void GiveMask(Person person)
        {
            if (_service.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " için maske VERİLEMEDİ !");
            }
        }
    }
}