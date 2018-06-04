# OutKillerProject

This class aim is that create standardization rules to functions return object. This structure has a few benefit like that I showed in below

> Help you to code standartizion and coverage of code's purpose.
> Look at the "SampleApplication.Task/PersonTask.cs" class to see implementation.  
> Type Safety and Error Preventing (like not found rec on Db exception)
> Encoruge To use SOLID prencibles and develope execeture and private method in class

Here is the sample piece of code to show usage.
``` c#
using SampleApplication.Models;
using ServiceResponse;
using System.Collections.Generic;
using System.Linq;
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
                Id = 1,
                Address = "Test",
                Age = 20,
                NameSurname = "CanBey"
            };
            Person personObj1 = new Person
            {
                Id = 2,
                Address = "Test1",
                Age = 21,
                NameSurname = "CanBey1"
            };
            personList.Add(personObj);
            personList.Add(personObj1);
        }
        public ServiceResult<Person> findPersonWithId(int id)
        {
            var foundedPerson = personList.FirstOrDefault(x => x.Id == id);
            return foundedPerson != null ? ServiceResult<Person>.SuccessResponse(foundedPerson) : ServiceResult<Person>.FailResponse("Record not found.");
        }
        public ServiceResult<List<Person>> getAllPersonWithHelper()
        {
            return ServiceResult<List<Person>>.SuccessResponse(personList);
        }
    }
}
```
