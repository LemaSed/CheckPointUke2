using CheckPointUke2Lema;
using NUnit.Framework;


namespace Unit_Testing
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		
		}

		[Test]
		public void TestPerson()
		{
			Person Meg = new Person("Lema", 28);
			string expected = "Lema is 28 years old.";
			Assert.IsTrue(Meg.Description() == expected);
		}

		[Test]
		public void TestEmployee()
		{
			Employee Meg = new Employee("Lema", 28, "15.10.2017");
			string expected = "This is an employee description:\nLema is 28 years old, and was hired 15.10.2017 in this company.";
			Assert.IsTrue(Meg.Description()==expected);
		}

		[Test]
		public void TestCompany()
		{
			Company Meg = new Company("BakerHughes", 150, "Lema", 28, "15.10.2017");
			string expected = "This is an employee description in company BakerHughes:\nLema is 28 years old, and was hired 15.10.2017 in BakerHughes\n" +
				"There are 150 people hired in this company";
			Assert.IsTrue(Meg.Description() == expected);
		}
	}
}