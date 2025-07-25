using System;
using System.Collections.Generic;
using System.Linq;
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


        public override string ToString()
        {
			return $"id = {ID} \n  Name = {Name} \n  slalar = {Salary:C} \n Gende = {Gendar} \n  hiring Date  {HiringDate} \n  SEcurityLevel ={Securitylevel}";
        }







    }
}
