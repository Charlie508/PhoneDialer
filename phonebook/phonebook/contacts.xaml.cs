using phonebook.Models;
using SQLite;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Runtime.Serialization;
using System.Collections;

namespace phonebook
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class contacts : ContentPage
    {
        public contacts()
        {
            InitializeComponent();
            
      
        }
       


        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("My Phone", "Chaitanya Shelar", "cancle");
        }

        private void addbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new testPage());
        }

        public void show()
        {
            SQLiteConnection con = new SQLiteConnection(App.LocalDatabase);
            con.CreateTable<ContactsClass>();
            //var data = (from stu in con.Table<ContactsClass>() select stu);
            var data = con.Query<ContactsClass>("SELECT * FROM ContactsClass");
            //mylist.ItemsSource = data;
            con.Close();
            mylist.ItemsSource = data;
        }

        private void refbtn_Clicked(object sender, EventArgs e)
        {
            show();
        }
    }
}