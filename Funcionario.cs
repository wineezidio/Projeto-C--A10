using System;


namespace A1
{
    internal class Funcionario
    {

        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }

        public Funcionario (string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public void Aumento(double Porcentagem)
        {
            Salary += Salary * Porcentagem / 100.0;

        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary;
        }
    }
}
