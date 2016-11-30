using System;

namespace polymorphism // Poly-"Multiple"-Morph-"Forms"
//Polymorphism -- Multiple Shapes/Forms 
{
	//Static Polymorphism
		// Function Overloading / Operator Overloading
	//Dynamic Polymorephism 
		// 1- abstract classes 
		// 2- virtual functions

	// Just Like Interfaces.
	// One Interface 1 -- n Many Function  
	public class Overloading
	{
		//Overloading -- Compile Time -- Static Binding -- Early Binding
		// Different Functionality of Method with "Same Name"
		// But Different Parameter List. -- All in Same Class 
		// same return time -- which one if just the return type


		//Override -- Runtime Time -- Dynamic Binding -- Late Binding
		// Same Name and Same Parameter List in different Class. 


		//different signatures -- return type not part of method signature "Name+ParameterList".
		//return type not part of signature. 

		// By depending on the parameters provided for the method, in the run time, compiler determines which version of the method to execute.

		//Overloading (not really polymorphism) is 
		// simply multiple functions which have the same name 
		// but different signatures 
		// (think multiple constructors for an object taking different numbers of arguments). 
		// Which method is called is known at compile time, 
		// --> because the arguments are specified at this time.

		public Overloading ()
		{
			Console.WriteLine ("This is Defualt Constructor -- NO ARGs");
		}

		public Overloading (int item)
		{
			Console.WriteLine ("This is Constructor -- with "+item);
		}

		public Overloading (int a,int b)
		{
			Console.WriteLine ("This is Constructore -- "+ a +" "+ b);
		}

		public void Show(){
			Console.WriteLine ("Hello No Args.");
		}

		public void Show(int item){
			Console.WriteLine ("Hello int "+item);
		}

		public void Show(float item){
			Console.WriteLine ("Hello float "+item);
		}

		public void Show(String item){
			Console.WriteLine ("Hello String "+item);
		}

		public int ShowX(){
			Console.WriteLine ("Hello Show");
			return 1;
		}

	}
}

