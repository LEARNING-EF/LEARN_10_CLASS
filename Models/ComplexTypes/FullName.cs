namespace Models.ComplexTypes
{
	[System.ComponentModel.DataAnnotations.Schema.ComplexType]
	public class FullName : object
	{
		public FullName() : base()
		{
		}

		// **********
		public string LastName { get; set; }
		// **********

		// **********
		public string FirstName { get; set; }
		// **********

		// **********
		public override string ToString()
		{
			string result = string.Empty;

			if (string.IsNullOrWhiteSpace(FirstName) == false)
			{
				result = FirstName.Trim();
			}

			if (string.IsNullOrWhiteSpace(LastName) == false)
			{
				result =
					$"{ result } { LastName.Trim() }".Trim();
			}

			return result;
		}
		// **********
	}
}
