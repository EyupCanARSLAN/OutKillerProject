using SampleApplication.Models;
using ServiceResponse;
using System.Collections.Generic;
namespace SampleApplication.Task
{
    public class PersonTask
    {
        private List<Person> personList;
        public PersonTask()
        {
            personList = new List<Person>();
            Person personObj = new Person
            {
                Address = "Test",
                Age = 20,
                NameSurname = "CanBey"
            };
            Person personObj1 = new Person
            {
                Address = "Test1",
                Age = 21,
                NameSurname = "CanBey1"
            };
            personList.Add(personObj);
            personList.Add(personObj1);
        }
        public ServiceResult<Person> findPersonWithId(int id)
        {
            return ServiceResult<Person>.FailResponse("RecordNotFound");
        }
        public ServiceResult<List<Person>> getAllPersonWithHelper()
        {
            return ServiceResult<List<Person>>.SuccessResponse(personList);
        }
        public List<Person> getAllPerson()
        {
            return personList;
        }
    }
}