using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Learning.Navigation
{
	public partial class MenuPage : ContentPage
	{
		public MenuPage()
		{
			InitializeComponent();


			var Students = new ObservableCollection<Student>();
			Students.Add(new Student() { Name = "Satider" });
			Students.Add(new Student() { Name = "Kamal" });
			Students.Add(new Student() { Name = "Jasleen" });


			lstStudents.ItemsSource = Students;
			lstStudents.ItemSelected += LstStudents_ItemSelected;
		}

		public void LstStudents_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var currentStudent = e.SelectedItem as Student;

			var page = new MenuDetail(currentStudent.Name);
		
			Navigation.PushAsync(page);

		}



	}




	public class Student
	{
		public string Name
		{
			get;
			set;
		}
	}
}