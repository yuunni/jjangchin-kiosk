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

    public ImageView Icon { get; }

    private void Button_Clicked(object sender, Tizen.NUI.Components.ClickedEventArgs e)
    {
        Window.Instance.Remove(this);
    }

     private void textField_TextChanged(object sender, TextField.TextChangedEventArgs e)
        {

            Dictionary<string, User> dict = new Dictionary<string, User>();

            dict.Add("2833670479702025", new User(
                new List<Item>(){ new Item("coffee","~.png"),
                new Item("apple","apple.png")},
                new List<Item>()));

            User value = dict["apple"];

            if (dict.ContainsKey(e.TextField.Text))
            {
                User user = dict[e.TextField.Text];
            }

            if (e.TextField.Text == "2833670479702025")
            {
                Window.Instance.Remove(this);
            }

            if(e.TextField.Text == "01088850354")
            {
                Window.Instance.Remove(this);

            }
            Tizen.Log.Info("NUI", "Text changed" + e.TextField.Text + "\n");
        }

    }
}
