using System;
using polymorphism;

namespace polymorphism
{
	// Just Like a Common Interface
	// Partial Class Implementation 
	// You can implement now, or Leave the implementation to Later Classes
	public abstract class Overriding
	{
		// "Dynamic polymorphism" is implemented by 
			// 1- abstract classes -- no implementation 
			// 2- virtual functions -- semi-implementation 

		/**
		 * Overridden functions are functions that have the same signature, 
		 * but are implemented in different derived classes.
		 * 
		 * At "compile time", usually the base class type is used to reference an object, 
		 * though at run time this object could be of a derived type, 
		 * so when an overridden method is called, 
		 * 
		 * the implementation that is called is 
		 * dependent on what kind of object is doing the calling 
		 * (base vs. a derived type) 
		 * which is unknown at compile time.
		 * */

		public int x;
		public int y;

		public void Show(int x){
			Console.WriteLine ("This is X = "+x);
		}

		public virtual void ShowX(float X){
			Console.WriteLine ("This is Semi-implementation in Parent ");
		}
		public abstract void Show();

	}

	public class Child : Overriding {

		// this is Local Method to the Child Class 
		// can not be called by Parent Class. 
		// But can access the parent (variables/methods/properties).
		public void GetAndSetX(){
			Console.WriteLine (this.x);
			this.x = 100;
			Console.WriteLine (this.x);
		}

		public void GetAndSetY(){
			Console.WriteLine (this.y);
			this.y = 100;
			Console.WriteLine (this.y);
		}
		//Show(int x) -- Not in Here -- 
		// but it will call the parent signature. 
		// you cannot override it unless abstract in parent

		public override void Show ()
		{
			Console.WriteLine ("This is Implementation .. ");
		}

		public override void ShowX (float X)
		{
			base.ShowX (X);
			Console.WriteLine ("This is Final Implementation of ShowX " + X);
		}

		/** 
		 * The virtual functions could be implemented differently in different inherited class 
		 *  and the call to these functions will be decided at runtime.
		 * 
		 * */




	}
}

