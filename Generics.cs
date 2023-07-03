using System;
namespace GenericsDemo
{
	//Generic means general form
	//It does not specify a particular Data type
	//We are using <> (angular bracket) with type name.
	//Typename <T> T is your type parameter
	//Generic allow us to a single class or method that can be
	//used for diff. datatype.
	//adv. : we can reuse code.
	public class Generics<T>
	{
		public T data;
		public Generics(T data)
		{
			this.data = data;
			Console.WriteLine(this.data);
		}
		public void GetMethod(T num)
		{
			Console.WriteLine(num);
		}
	}
	public class Generic
	{
		public void GenericMethod<T> (T num)
		{
			Console.WriteLine(num);
		}
	}
}

