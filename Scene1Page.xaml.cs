using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using System.Text.RegularExpressions;

namespace jjangchin_kiosk
{
    public partial class Scene1Page : View
    {

        public Scene1Page()
        {
            FontClient.Instance.AddCustomFontDirectory(Tizen.Applications.Application.Current.DirectoryInfo.Resource);
            InitializeComponent();
        }

        private void Button_ClickEvent(object sender, Tizen.NUI.Components.Button e)
        {
            Window.Instance.Add(new MainPage1());
        }
    }
}
