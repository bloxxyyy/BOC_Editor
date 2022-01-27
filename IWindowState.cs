using Microsoft.Xna.Framework;

namespace BOC_Editor {
	internal interface IWindowState {
		void Draw(GameTime gameTime);
		void Update(GameTime gameTime);
	}
}