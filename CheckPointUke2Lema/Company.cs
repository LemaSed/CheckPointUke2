using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPointUke2Lema
{
	public class Company: Employee
	{
		private string _companyName { get; set; }
		private int _employeeCount { get; set; }
		public Company ( string companyName, int employeeCount, string name = "", int age = 0, string hireDate="00.00.00" ) : base (name, age, hireDate)
		{
			_companyName = companyName;
			_employeeCount = employeeCount;
		}

		public override string Description()
		{
			string describe = "This is an employee description in company " + _companyName + ":\n" +
				_name + " is " + _age + " years old, and was hired " + _hireDate + " in " + _companyName +"\n" +
				"There are " + _employeeCount + " people hired in this company";

			return describe;
		}

	}
}
