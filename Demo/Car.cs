using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    #region Part 06 Class

    internal class Car
	{

		#region Attributes

		private int id;
		private string? model;
		private double speed;

		#endregion

		#region Properties

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public string? Model
		{
			get { return model; }
			set { model = value; }
		}

		public double Speed
		{
			get { return speed; }
			set { speed = value; }
		}


		#endregion

		#region Constructors

		public Car()
		{

		}

		public Car(int id, string? model, double speed)
		{
			this.id = id;
			this.model = model;
			this.speed = speed;

			Console.WriteLine("Constructor 1");

		}
		public Car(int id, string? model) : this(id, model, 120)//Constructor chaining ( Chain on constructor [Car(int id,string? model,double speed)] , let it implement the redundant code )
		{
			//this.id = id;
			//this.model = model ;				
			//this.speed = 120;				

			Console.WriteLine("Constructor 2");
		}
		public Car(int id) : this(id, "Kia scerato")//Constructor chaining ( Chain on constructor [Car(int id,string? model)] , let it implement the redundant code )
		{
			//this.id = id;
			//this.model = model ;				
			//this.speed = speed;	

			Console.WriteLine("Constructor 3");
		}

		#endregion

		#region Methods

		public override string ToString()//Return object state as string.
		{
			return $"(Id = {id}) - (Model = {model}) - (Speed = {speed})";
		}

		#endregion

	} 

	#endregion
}
