using System;

namespace DoFactory.GangOfFour.Singleton.Structural
{
	
	// MainApp startup application

	class MainApp
	{
		
		static void Main()
		{
			// Constructor is protected -- cannot use new
			Singleton s1 = Singleton.Instance();
			Singleton s2 = Singleton.Instance();

			if (s1 == s2)
			{
				Console.WriteLine("Objects are the same instance");
			}

			// Wait for user
			Console.Read();
		}
	}

	// "Singleton"

	class Singleton
	{
		private static Singleton instance;

		// Note: Constructor is 'protected'
		protected Singleton() 
		{
		}

		public static Singleton Instance()
		{
			// Use 'Lazy initialization'
			if (instance == null)
			{
				instance = new Singleton();
			}

			return instance;
		}
	}
}

namespace Structural {
	/// <summary>
	/// MainApp startup application
	/// </summary>
	public class MainApp {

		public MainApp(){

		}

		~MainApp(){

		}

		private static void Main(){

		}

	}

	/// <summary>
	/// "Singleton"
	/// </summary>
	public class Singleton {

		private static Singleton instance;



		~Singleton(){

		}

		/// <summary>
		/// Note: Constructor is 'protected'
		/// </summary>
		protected Singleton(){

		}

		public static Singleton Instance(){

			return null;
		}

	}//end Singleton//end MainApp

}//end namespace Structural
