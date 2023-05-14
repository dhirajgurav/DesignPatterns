using Newtonsoft.Json;

namespace Prototype
{
    /// <summary>
    /// Prototype
    /// </summary>
    public abstract class Person
    {
        public abstract string Name { get; set; }

        public abstract Person Clone(bool deepClone);
    }

    /// <summary>
    /// ConcretePrototype1
    /// </summary>
    public class Manager : Person
    {
        public override string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }
        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var objAsJson = JsonConvert.SerializeObject(this);
                return JsonConvert.DeserializeObject<Manager>(objAsJson);
            }
            return (Person)MemberwiseClone();
        }
    }

    public class Employee : Person
    {
        public Manager Manager { get; set; }
        public override string Name { get ; set ; }

        public Employee(string name, Manager manager)
        {
            Name = name;
            Manager = manager;
        }
        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var objAsJson = JsonConvert.SerializeObject(this);
                return JsonConvert.DeserializeObject<Employee>(objAsJson);
            }
            return(Person)MemberwiseClone();
        }
    }
}
