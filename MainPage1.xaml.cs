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

        private void Button_ClickEvent1(object sender, Tizen.NUI.Components.Button e)
        {
            Window.Instance.Add(new KioskPage1());
        }
        private void Button_ClickEvent2(object sender, Tizen.NUI.Components.Button e)
        {
            Window.Instance.Add(new EasySelectPage());
        }

        public ImageView Icon { get; }


        private void textField_TextChanged(object sender, TextField.TextChangedEventArgs e)
        {

            if (Program.globalData.ContainsKey(e.TextField.Text))
            {
                User user = Program.globalData[e.TextField.Text];
                Window.Instance.Add(new KioskPage2());
            }


            Tizen.Log.Info("NUI", "Data Changed" + e.TextField.Text + "\n");

        }

    }
}
