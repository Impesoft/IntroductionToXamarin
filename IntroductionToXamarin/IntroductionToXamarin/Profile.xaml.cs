using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroductionToXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void OnSaveInfo(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(firstName.Text) && !string.IsNullOrEmpty(lastName.Text))
            {
                ConcatInfo.Text = $"Welkom {firstName.Text} {lastName.Text}\nJe bent {age.Text}jaar jong en je hobby's zijn {Hobbies.Text}.";
            }
        }
    }
}