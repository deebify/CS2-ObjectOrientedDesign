using System;
using System.Security.Policy;

namespace polymorphism
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Overloading overload = new Overloading ();
			overload.Show ();
			overload.Show (2);
			overload.Show (0.3f);
			overload.Show ("Yassine");
			overload.ShowX ();

			Overriding overriding = new Child ();
			overriding.Show ();
			overriding.Show (2);

			overriding.ShowX (12.0f);

//			Child child = new Child ();
//			child.GetAndSetX ();
//			child.GetAndSetY ();
		}
	}
}
