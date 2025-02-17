﻿using System.Collections.Generic;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace jjangchin_kiosk
{
	public partial class KioskPage2 : View
{
        string Type,UserName, FirstDrink, SecondDrink, ThirdDrink;


        public KioskPage2()
        {
            InitializeComponent();
            
            Type = "User";
            UserName = Program.selectedUser.Name;
            FirstDrink = "1위 음료";
            SecondDrink = "2위 음료";
            ThirdDrink = "3위 음료";

            this.UserText.Text = $"[{UserName}]님이 가장 최근에 주문하신 음료는 [{Program.selectedUser.Resent[0].Name}]입니다.";
            Button btn = new Button();
            btn.Text = Program.selectedUser.Resent[0].Name;
            btn.FontFamily = "배달의민족주아";
            btn.TextColor = Color.Black;
            btn.BackgroundImage = "*Resource*/images/button_background.png";
            btn.Margin = new Extents(0, 20, 20, 20);
            this.btnList.Add(btn);
            btn.Clicked += (o, i) =>
            {
                Window.Instance.Add(new SelectPage(Program.selectedUser.Resent[0].Name, 2));
            };
            this.UserText2.Text = $"1위-[{Program.selectedUser.Recommand[0].Name}]  2위-[{Program.selectedUser.Recommand[1].Name}]  3위-[{Program.selectedUser.Recommand[2].Name}]";



            foreach (Item v in Program.selectedUser.Recommand)
            {
                Button btn2 = new Button();
                btn2.Text = v.Name;
                btn2.FontFamily = "배달의민족주아";
                btn2.TextColor = Color.Black;
                btn2.BackgroundImage = "*Resource*/images/button_background.png";
                btn2.Margin = new Extents(0, 20, 0, 20);
                btn2.Clicked += (o, i) =>
                {
                    Window.Instance.Add(new SelectPage(v.Name, 2));
                };
                this.btnList2.Add(btn2);
            }
        }

        private void Ade_Button_ClickEvent(object sender, Button e)
        {
            UserText.Text = "";
            UserText2.Text = "";
            new List<View>(btnList.Children).ForEach(btnList.Remove);
            new List<View>(btnList2.Children).ForEach(btnList2.Remove);

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
            UserText2.Text = "";
            new List<View>(btnList.Children).ForEach(btnList.Remove);
            new List<View>(btnList2.Children).ForEach(btnList2.Remove);
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
                        this.UserText.Text = $"[{UserName}]님이 가장 최근에 주문하신 음료는 [{Program.selectedUser.Resent[0].Name}]입니다.";
                        Button btn = new Button();
                        btn.Text = Program.selectedUser.Resent[0].Name;
                        btn.FontFamily = "배달의민족주아";
                        btn.TextColor = Color.Black;
                        btn.BackgroundImage = "*Resource*/images/button_background.png";
                        btn.Margin = new Extents(0, 20, 20, 20);
                        this.btnList.Add(btn);
                        btn.Clicked += (o, i) =>
                        {
                            Window.Instance.Add(new SelectPage(Program.selectedUser.Resent[0].Name, 2));
                        };
                    this.UserText2.Text = $"1위-[{FirstDrink}]  2위-[{SecondDrink}]  3위-[{ThirdDrink}]";
                    List<string> li = new List<string>()
                    {
                    FirstDrink,
                    SecondDrink,
                    ThirdDrink
                    };

                foreach (string v in li)
                {
                    Button btn2 = new Button();
                    btn2.Text = v;
                    btn2.FontFamily = "배달의민족주아";
                    btn2.TextColor = Color.Black;
                    btn2.BackgroundImage = "*Resource*/images/button_background.png";
                    btn2.Margin = new Extents(0, 20, 0, 20);
                    btn2.Clicked += (o, i) =>
                    {
                        Window.Instance.Add(new SelectPage(v, 2));
                    };
                    this.btnList2.Add(btn2);
                }
                }

                Type = "User";


        }
    }
}
