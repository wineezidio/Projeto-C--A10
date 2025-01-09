using System.Globalization;

namespace A1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Emplyoee #" + (i) + ":");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(name, id, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int searId = int.Parse(Console.ReadLine());

            Funcionario emp = list.Find(x => x.Id == searId);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.Aumento(porcent);

            }

            else
            {
                Console.Write("This id does not exist! ");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
