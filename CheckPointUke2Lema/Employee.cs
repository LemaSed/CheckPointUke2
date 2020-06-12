using System;
using System.Collections.Generic;
using System.Text;


namespace CheckPointUke2Lema
{
	public class Employee: Person 
	{
		public string _hireDate { get; set;}
		public Employee(string name, int age, string  hireDate) : base ( name, age)
		{
			_hireDate = hireDate;
		}

		public override string Description()
		{
			string describe = "This is an employee description:\n" +
				_name + " is " + _age +" years old, and was hired " + _hireDate + " in this company.";
			
			return describe;
		}

	}
}
