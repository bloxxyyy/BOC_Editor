using Apos.Gui;
using Microsoft.Xna.Framework;

namespace BOC_Editor {
	internal class UnitEditorWindow : IWindowState {
		public void Draw(GameTime gameTime) {
			
		}

		public void Update(GameTime gameTime) {
			MarginalPanel.Push(5, 5, 0, 5);
				MarginalPanel.Push(5, 5, 5, 5, Color.Black);
					MarginalPanel.Push(5, 5, 5, 5, Color.White);
						Screen();
					MarginalPanel.Pop();
				MarginalPanel.Pop();
			MarginalPanel.Pop();
		}

		private Color black = Color.Black;
		private int font = 22;
		private void Screen() {

			GridPanel.Push(2, null, 3);

			Panel.Push();
			
			UnitListWindow();

			MarginalPanel.Push(0, 5, 0, 0).End();

			GridPanel.Push(2, null, 3);

			MarginalPanel.Push(0, 0, 0, 5);
			Button.Put("+", Color.Black, Color.LightGreen);
			MarginalPanel.Pop();

			Button.Put("-", Color.Black, Color.MediumVioletRed);
			GridPanel.Pop();

			Panel.Pop();

			MarginalPanel.Push(0, 0, 5, 0);
			UnitDataWindow();
			MarginalPanel.Pop();

			GridPanel.Pop();
		}

		private void UnitDataWindow() {
			Scaler.Push();
			Button.Put("ShieldHero", black, fontSize: font);
			Button.Put("er", black, fontSize: font);
			Button.Put("ew", black, fontSize: font);
			Scaler.Pop();
		}

		private void UnitListWindow() {
			MarginalPanel.Push(5, 5, 5, 5, Color.Black);
			MarginalPanel.Push(5, 5, 5, 5, Color.White);
			GridPanel.Push(1, null, 2);
			Button.Put("ShieldHero", black, fontSize: font);
			MarginalPanel.Push(0, 5, 0, 0).End();
			Button.Put("ShieldHero", black, fontSize: font);
			MarginalPanel.Push(0, 5, 0, 0).End();
			Button.Put("ShieldHero", black, fontSize: font);
			MarginalPanel.Push(0, 5, 0, 0).End();
			Button.Put("ShieldHero", black, fontSize: font);
			MarginalPanel.Push(0, 5, 0, 0).End();
			Button.Put("ShieldHero", black, fontSize: font);
			MarginalPanel.Push(0, 5, 0, 0).End();
			Button.Put("ShieldHero", black, fontSize: font);
			GridPanel.Pop();
			MarginalPanel.Pop();
			MarginalPanel.Pop();
		}
	}
}