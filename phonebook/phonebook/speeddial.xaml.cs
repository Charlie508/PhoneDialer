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
    public partial class speeddial : ContentPage
    {
        public speeddial()
        {
            InitializeComponent();
        }

        private void speedbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new addPage());
        }
    }
}