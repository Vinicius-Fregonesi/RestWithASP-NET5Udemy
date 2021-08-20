using RestWithASPNETUdemy.Data.Converter.Contract;
using RestWithASPNETUdemy.Data.Converter.VO;
using RestWithASPNETUdemy.model;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Data.Converter.Implementations
{
    public class PersonConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
    {
        public Person Parse(PersonVO origin)
        {
            if (origin == null)
            {
                return null;
            }
            else
            {
                return new Person 
                {
                    id = origin.Id,
                    FirstName = origin.FirstName,
                    LastName= origin.LastName,
                    Gender= origin.Gender,
                    Address= origin.Address
                };
            }
        }

        public List<Person> Parse(List<PersonVO> origin)
        {
            if (origin == null)
            {
                return null;
            }
            return origin.Select(item => Parse(item)).ToList();
        }

        public PersonVO Parse(Person origin)
        {
            if (origin == null)
            {
                return null;
            }
            else
            {
                return new PersonVO
                {
                    Id = origin.id,
                    FirstName = origin.FirstName,
                    LastName = origin.LastName,
                    Gender = origin.Gender,
                    Address = origin.Address
                };
            }
        }

        public List<PersonVO> Parse(List<Person> origin)
        {
            if (origin == null)
            {
                return null;
            }
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
