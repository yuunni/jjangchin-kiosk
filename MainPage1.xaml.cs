using System.Collections.Generic;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;

namespace jjangchin_kiosk{
    public partial class MainPage1 : View
{
    public MainPage1()
    {
        InitializeComponent();
    }

        private void Button_ClickEvent(object sender, Tizen.NUI.Components.Button e)
        {
            Window.Instance.Add(new KioskPage1());
        }

        public ImageView Icon { get; }


        private void textField_TextChanged(object sender, TextField.TextChangedEventArgs e)
        {

            if (Program.globalData.ContainsKey(e.TextField.Text))
            {
                User user = Program.globalData[e.TextField.Text];
            }


            Tizen.Log.Info("NUI", "Data Changed" + e.TextField.Text + "\n");

        }

    }
}
