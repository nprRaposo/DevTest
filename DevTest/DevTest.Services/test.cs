using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splats.Services
{
	public interface IInterface
	{
		void function1();
		int function2();
	}

	class Class1 : IInterface
	{
		void IInterface.function1()
		{
			string Fun = "hello, world";
			string s = Fun;
			typeof(int);
			Type t = typeof();
			Console.WriteLine(s);
			Console.WriteLine(t);
		}

		void function1() { }
		int IInterface.function2() { return 1; }
	}
}
