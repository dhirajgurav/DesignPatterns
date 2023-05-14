using Prototype;

Console.Title = "Prototype";

var manager = new Manager("Cindy");
var managerclone = (Manager) manager.Clone();
Console.WriteLine($"Manager was cloned : {managerclone.Name}");

var employee = new Employee("Kevin", manager);
var employeeClone = (Employee) employee.Clone();
managerclone.Name = "Karen";
Console.WriteLine($"Employee cloned : {employeeClone.Name}, " +
    $" with manager {employeeClone.Manager.Name}");