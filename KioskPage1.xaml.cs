using Tizen.NUI;
using Tizen.NUI.BaseComponents;

namespace jjangchin_kiosk
{
	public partial class KioskPage1 : View
{
    public KioskPage1()
    {
        InitializeComponent();
    }
        private void Button_ClickEvent(object sender, Tizen.NUI.Components.Button e)
        {
            Window.Instance.Add(new KioskPage2());
        }
    }
}
