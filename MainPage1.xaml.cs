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
            Tizen.Log.Info("NUI", "Text changed" + e.TextField.Text + "\n");
        }

    }
}
