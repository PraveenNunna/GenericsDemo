using System.Collections.Generic;
using System.Collections;

namespace GenericsDemo
{
    public class CustomCollection<T>
    {
        public CustomCollection()
        {
            Collection = new ArrayList();
        }
        public ArrayList Collection { get; set; }
        public int Add(T item)
        {
            Collection.Add(item);
            return Collection.Count;
        }
    }

    public class UseExample1
    {
        public void AddItems()
        {
            var intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);

            var stringList = new CustomCollection<string>();

            stringList.Add("Praveen");
            stringList.Add("Nunna");

            var employeeList = new CustomCollection<Employee>();

            employeeList.Add(new Employee() { Id = 1, Name = "Employee1" });
        }
    }

    class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
