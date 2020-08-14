namespace Models
{
	public class Person : BaseEntity
	{
		public Person() : base()
		{
			FullName =
				new ComplexTypes.FullName();
		}

		// **********
		public int Age { get; set; }
		// **********

		// **********
		// **********
		// **********
		[System.ComponentModel.Browsable(false)]
		public ComplexTypes.FullName FullName { get; set; }
		// **********

		// **********
		[System.ComponentModel.DisplayName(displayName: "Full Name")]
		public string DisplayFullName
		{
			get
			{
				string result = FullName.ToString();

				if (result == string.Empty)
				{
					result = "Undefined";
				}

				return result;
			}
		}
		// **********
		// **********
		// **********
	}
}
