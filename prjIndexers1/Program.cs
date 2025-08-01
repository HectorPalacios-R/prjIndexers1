namespace prjIndexers1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee("E001", "John", "Doe", "Developer", 60000);
            employee[1] = "Jane";
            Console.WriteLine(employee[0]);
            Console.WriteLine(employee[1]);
            Console.WriteLine(employee[2]);
            Console.WriteLine(employee[3]);
            Console.WriteLine(employee[4]);
            employee["salary"] = 65000;
            Console.WriteLine("Employee Number: " + employee["empnumber"]);
            Console.WriteLine("Name: " + employee["name"]);
            Console.WriteLine("Surname: " + employee["surname"]);
            Console.WriteLine("Job Title: " + employee["jobtitle"]);
            Console.WriteLine("Salary: " + employee["salary"]);
            Console.ReadLine();
        }
    }
}
