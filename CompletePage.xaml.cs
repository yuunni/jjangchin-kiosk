using Tizen.NUI;
using Tizen.NUI.BaseComponents;

namespace jjangchin_kiosk
{

	public partial class CompletePage : View
{

        public CompletePage()
        {
            InitializeComponent();
        }
        private void Button_ClickEvent(object sender, Tizen.NUI.Components.Button e)
        {
            Window.Instance.Add(new Scene1Page());
        }
    }
}
