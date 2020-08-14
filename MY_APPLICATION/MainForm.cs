using System.Linq;

namespace MY_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void AddSomeDataButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.Person person = null;

				person =
					new Models.Person
					{
						Age = 30,
					};

				person.FullName.FirstName = "   Ali   ";
				person.FullName.LastName = "   Alavi    ";

				databaseContext.People.Add(person);

				person =
					new Models.Person
					{
						Age = 20,
					};

				person.FullName.FirstName = "   Mohammad   ";

				databaseContext.People.Add(person);

				person =
					new Models.Person
					{
						Age = 40,
					};

				person.FullName.LastName = "   Ghaderi   ";

				databaseContext.People.Add(person);

				person =
					new Models.Person
					{
						Age = 25,
					};

				databaseContext.People.Add(person);

				databaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private void DisplayDataButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var people =
					databaseContext.People
					.OrderBy(current => current.Age)
					.ToList()
					;

				peopleDataGridView.DataSource = people;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}
	}
}
