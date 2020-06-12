using System;
using System.Text;

namespace CheckPointUke2Lema
{
	class Program
	{
		static void Main(string[] args)
		{

			Company previousJob = new Company("BakerHughes", 150, "Lema", 28, "15.10.2018");
			Console.WriteLine(previousJob.Description());

			//GITHUB repository: https://github.com/LemaSed/CheckPointUke2
		}
	}
}
