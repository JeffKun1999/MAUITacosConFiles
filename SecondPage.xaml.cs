﻿
namespace MJSCJR_TacoslaEnredadaInterfaz
{
    public partial class SecondPage : ContentPage
    {

        public SecondPage()
        {
            InitializeComponent();
        }

        private async void OnBtnRegresarHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }

}
