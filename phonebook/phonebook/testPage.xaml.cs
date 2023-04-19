using phonebook.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace phonebook
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class testPage : ContentPage
    {
        public testPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            SQLiteConnection con = new SQLiteConnection(App.LocalDatabase);
            con.CreateTable<ContactsClass>();
            ContactsClass cc = new ContactsClass()
            {
                title = titlepicker.SelectedItem.ToString(),
                fullname = numentry.Text,
                ph1type = conpicker.SelectedItem.ToString(),
                ph1 = numentry.Text,
                email = mailentry.Text

            };

            var data = con.Insert(cc);
            if(data>0)
            {
                con.Close();
                DisplayAlert("Hi Bro", "Your record added successfully", "ok");

            }
            else
            {
                DisplayAlert("sorry Bro", "failed to add record in datdbase", "try again");
            }

            

        }

        private void mybtn2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}