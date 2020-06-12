using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPointUke2Lema
{
	public class Person
	{
		public string _name { get; set; }
		public int _age { get; set; }

		public Person (string name, int age)
		{
			_name = name;
			_age = age; 
		}

		public virtual string Description()
		{
			string description = _name + " is " + _age + " years old." ;
			return description;
		}
	}
}
