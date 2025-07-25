using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class Employee
    {

		private int? id;

		public int?  ID
		{
			get { return id; }
			set {

				if (value <= 0  &&  value is null)
				{
					id = 1;
				}
				id = value;
			
			}
		}

		private string ? name;

		public string ?Name
		{
			get { return  name; }
			set { 
			
				if (!string.IsNullOrEmpty(value))
				{

					name = value;
				}
				else
				{
					name = "no name ";
				}
			
			
			}
		}


        public decimal Salary { get; set; }

        public Gendar Gendar{ get; set; }

        public SecurityLevel Securitylevel { get; set; }


        public HireDate HiringDate{ get; set; }



        public Employee()
        {
			HiringDate = new HireDate();
        }

		//create employye 

		static Employee[]? Createmployee (int Size)
		{
			if (Size > 0)

			{
				Employee[] employees = new Employee[Size];
				for (int i = 0; i < Size; i++)
				{
					employees[i] = new Employee();	
				}
				
			}
			return null;
		}


        // insert employee data 
        public static void InsertData(Employee[] employees)
        {
            string name;
            string genderinput;
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Enter Data for Employee number {i + 1}");
                Console.WriteLine("==========================================");
                Console.WriteLine("Enter the Name ");
                name = Console.ReadLine();
                employees[i].name = name;
                Console.WriteLine("Enter the ID ");
                employees[i].id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Salary ");
                employees[i].Salary = Decimal.Parse(Console.ReadLine());
                Console.WriteLine("enter your Gender 1 for male 2 for female ");

                int valid = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(Gendar), valid))
                {
                    employees[i].Gendar = (Gendar)valid;
                }


                Console.WriteLine("Hint : Guest =1 , Developer = 2 , secretary = 3 , DBA = 4");

                int securityInput = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(SecurityLevel), securityInput))
                {
                    employees[i].Securitylevel = (SecurityLevel)securityInput;
                }

                Console.WriteLine("Enter the HireDate ");
                Console.WriteLine("==========================================");
                Console.WriteLine("Enter the Day ");
                int day = int.Parse(Console.ReadLine());
                employees[i].HiringDate.Day= day;

                Console.WriteLine("Enter the Month ");
                int month = int.Parse(Console.ReadLine());
                employees[i].HiringDate.Month = month;

                Console.WriteLine("Enter the Year ");
                int year = int.Parse(Console.ReadLine());
                employees[i].HiringDate.Year = year;
            }
        }


        public override string ToString()
        {
			return $"id = {ID} \n  Name = {Name} \n  slalar = {Salary:C} \n Gende = {Gendar} \n  hiring Date  {HiringDate} \n  SEcurityLevel ={Securitylevel}";
        }







    }
}
