using System.Collections.Generic;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace jjangchin_kiosk
{
	public partial class KioskPage2 : View
{
        string Type,UserName, R_Drink;

        public KioskPage2()
        {
            InitializeComponent();
            Type = "User";
            UserName = "임동연";
            R_Drink = "맛있는 음료";
            this.UserText.Text = $"[{UserName}]님이 가장 최근에 주문하신 음료는 [{R_Drink}]입니다.";
            Button btn = new Button();
            btn.Text = R_Drink;
            btn.FontFamily = "배달의민족주아";
            btn.TextColor = Color.Black;
            btn.BackgroundImage = "*Resource*/images/button_background.png";
            this.btnList.Add(btn);
        }

        private void Ade_Button_ClickEvent(object sender, Button e)
        {
            UserText.Text = "";
            new List<View>(btnList.Children).ForEach(btnList.Remove);
            UserText.Reset();

            if (Type != "Ade")
            {
                this.adeBtn.BackgroundImage = "*Resource*/images/Selectpage.png";
                this.UserBtn.BackgroundImage = "*Resource*/images/Selectpage2.png";
                this.coffeeBtn.BackgroundImage = "*Resource*/images/Selectpage2.png";
                List<string> li = new List<string>()
                {
                "오렌지 에이드",
                "자몽 에이드",
                "레몬 에이드",
                "망고 에이드",
                "딸기 에이드"
                };

                foreach (string v in li)
                {
                    Button btn = new Button();
                    btn.Text = v;
                    btn.FontFamily = "배달의민족주아";
                    btn.TextColor = Color.Black;
                    btn.BackgroundImage = "*Resource*/images/button_background.png";
                    btn.Margin = new Extents(0, 20, 0, 20);
                    btn.Clicked += (o, i) =>
                    {
                        Window.Instance.Add(new SelectPage(v,2));
                    };
                    this.btnList.Add(btn);
                }

            }

            Type = "Ade";


        }

        private void Coffee_Button_ClickEvent(object sender, Tizen.NUI.Components.Button e)
        {
            UserText.Text = "";
            new List<View>(btnList.Children).ForEach(btnList.Remove);
            UserText.Reset();
            if (Type != "Coffee")
            {
                this.adeBtn.BackgroundImage = "*Resource*/images/Selectpage2.png";
                this.UserBtn.BackgroundImage = "*Resource*/images/Selectpage2.png";
                this.coffeeBtn.BackgroundImage = "*Resource*/images/Selectpage.png";
                List<string> li = new List<string>()
                {
                "아메리카노",
                "라떼",
                "바닐라 라떼",
                "카페 모카",
                "아인슈페너",
                "연유 라떼"
                };

                foreach (string v in li)
                {
                    Button btn = new Button();
                    btn.Text = v;
                    btn.FontFamily = "배달의민족주아";
                    btn.TextColor = Color.Black;
                    btn.BackgroundImage = "*Resource*/images/button_background.png";
                    btn.Margin = new Extents(0, 20, 0, 20);
                    btn.Clicked += (o, i) =>
                    {
                        Window.Instance.Add(new SelectPage(v,2));
                    };
                    this.btnList.Add(btn);


                }
            }

            Type = "Coffee";
        }
            private void User_Button_ClickEvent(object sender, Tizen.NUI.Components.Button e)
            {
                if(Type != "User")
                    { 
                        new List<View>(btnList.Children).ForEach(btnList.Remove);
                        this.adeBtn.BackgroundImage = "*Resource*/images/Selectpage2.png";
                        this.coffeeBtn.BackgroundImage = "*Resource*/images/Selectpage2.png";
                        this.UserBtn.BackgroundImage = "*Resource*/images/Selectpage.png";
                        this.UserText.Text = $"[{UserName}]님이 가장 최근에 주문하신 음료는 [{R_Drink}]입니다.";
                        Button btn = new Button();
                        btn.Text = R_Drink;
                        btn.FontFamily = "배달의민족주아";
                        btn.TextColor = Color.Black;
                        btn.BackgroundImage = "*Resource*/images/button_background.png";
                        btn.Margin = new Extents(0, 20, 20, 20);
                        this.btnList.Add(btn);
                        btn.Clicked += (o, i) =>
                        {
                            Window.Instance.Add(new SelectPage(R_Drink,2));
                        };
            }

                Type = "User";


        }
    }
}
