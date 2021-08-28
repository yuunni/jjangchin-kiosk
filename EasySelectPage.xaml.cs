using System.Collections.Generic;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace jjangchin_kiosk
{
	public partial class EasySelectPage : View
	{
		string Drink = "Null";
		string SelectDrink = "NUll";
		public EasySelectPage()
		{
			InitializeComponent();
		}

		private void Coffee_Button_ClickEvent(object sender, Button e)
		{
			switch (Drink)
			{
				case "Null":
					Drink = "Coffee";
					coffeeBtn.BackgroundImage = "*Resource*/images/NoMilk.png";
					adeBtn.BackgroundImage = "*Resource*/images/Milk.png";
					break;
				case "Coffee":
					SelectDrink = "아메리카노";
					Window.Instance.Add(new SelectPage(SelectDrink,1));
					break;
				case "Milk":
					SelectDrink = "라떼";
					Window.Instance.Add(new SelectPage(SelectDrink,1));
					break;
				case "Cream":
					SelectDrink = "아인슈페너";
					Window.Instance.Add(new SelectPage(SelectDrink,1));
					break;
				case "Syrup":
					SelectDrink = "연유 라떼";
					Window.Instance.Add(new SelectPage(SelectDrink, 1));
					break;
				case "Choco":
					SelectDrink = "카페 모카";
					Window.Instance.Add(new SelectPage(SelectDrink, 1));
					break;
				case "Ade":
					Drink = "Orange";
					coffeeBtn.BackgroundImage = "*Resource*/images/Orange.png";
					adeBtn.BackgroundImage = "*Resource*/images/Mango.png";
					break;
				case "Orange":
					SelectDrink = "오렌지 에이드";
					Window.Instance.Add(new SelectPage(SelectDrink, 1));
					break;
				case "Sour":
					SelectDrink = "레몬 에이드";
					Window.Instance.Add(new SelectPage(SelectDrink, 1));
					break;
				case "GFA":
					SelectDrink = "자몽 에이드";
					Window.Instance.Add(new SelectPage(SelectDrink, 1));
					break;
			}

		}

		private void Ade_Button_ClickEvent(object sender, Button e)
		{
			switch (Drink)
			{
				case "Null":
					Drink = "Ade";
					coffeeBtn.BackgroundImage = "*Resource*/images/SweetAde.png";
					adeBtn.BackgroundImage = "*Resource*/images/NoSweetAde.png";
					break;
				case "Coffee":
					Drink = "Milk";
					coffeeBtn.BackgroundImage = "*Resource*/images/NoSweet.png";
					adeBtn.BackgroundImage = "*Resource*/images/Sweet.png";
					break;
				case "Milk":
					Drink = "Cream";
					coffeeBtn.BackgroundImage = "*Resource*/images/Cream.png";
					adeBtn.BackgroundImage = "*Resource*/images/NoCream.png";
					break;
				case "Cream":
					Drink = "Syrup";
					coffeeBtn.BackgroundImage = "*Resource*/images/SweetMilk.png";
					adeBtn.BackgroundImage = "*Resource*/images/Syrup.png";
					break;
				case "Syrup":
					Drink = "Choco";
					coffeeBtn.BackgroundImage = "*Resource*/images/Choco.png";
					adeBtn.BackgroundImage = "*Resource*/images/Vanilla.png";
					break;
				case "Choco":
					SelectDrink = "바닐라 라떼";
					Window.Instance.Add(new SelectPage(SelectDrink,1));
					break;
				case "Orange":
					SelectDrink = "망고 에이드";
					Window.Instance.Add(new SelectPage(SelectDrink,1));
					break;
				case "Ade":
					Drink = "Sour";
					coffeeBtn.BackgroundImage = "*Resource*/images/Sour.png";
					adeBtn.BackgroundImage = "*Resource*/images/NoSour.png";
					break;
				case "Sour":
					Drink = "GFA";
					coffeeBtn.BackgroundImage = "*Resource*/images/GF.png";
					adeBtn.BackgroundImage = "*Resource*/images/STB.png";
					break;
				case "GFA":
					SelectDrink = "딸기 에이드";
					Window.Instance.Add(new SelectPage(SelectDrink,1));
					break;
			}
		}
	}
}
