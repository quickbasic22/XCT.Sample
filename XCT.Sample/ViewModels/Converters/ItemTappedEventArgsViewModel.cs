using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace Xamarin.CommunityToolkit.Sample.ViewModels.Converters
{
	public class ItemTappedEventArgsViewModel
	{
		public IEnumerable<Person> Items { get; } = new List<Person>()
		{
			new Person() { Id = 1, Name = "Person 1" },
			new Person() { Id = 2, Name = "Person 2" },
			new Person() { Id = 3, Name = "Person 3" }
		};

		public ICommand ItemTappedCommand { get; } =
			CommandFactory.Create<Person>(person => Application.Current.MainPage.DisplayAlert("Item Tapped: ", person?.Name, "Cancel"));
	}

	public class Person
	{
		public int Id { get; set; }

		public string Name { get; set; } = string.Empty;
	}
}