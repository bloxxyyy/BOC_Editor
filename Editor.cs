using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using MonoGame.Extended.ViewportAdapters;
using FontStashSharp;
using Koko.Gui;
using Koko.Gui.KokoGui.Gui;
using Koko.Gui.KokoGui.Components;

namespace BOC_Editor {
	public class Editor : Game {

		private IWindowState _CurrentState;

		public static Vector2 DefaultWindowSize;

		private GraphicsDeviceManager _graphics;
		//private IMGUI _ui;
		private BoxingViewportAdapter _ViewportAdapter;
		private OrthographicCamera _Camera;
		private SpriteBatch _spriteBatch;

		public Editor() {
			_CurrentState = EditorWindowDict.GetState(EditorWindowDict.EWindowType.Overview);

			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;

			Gui.GUI.CurrentComponentReference = Gui.GUI;
		}

		protected override void Initialize() {
			_graphics.IsFullScreen = false;
			_graphics.PreferredBackBufferWidth = GraphicsDevice.DisplayMode.Width;
			_graphics.PreferredBackBufferHeight = GraphicsDevice.DisplayMode.Height;
			_graphics.ApplyChanges();
			base.Initialize();
		}

		protected override void LoadContent() {

			FontHelper.Add(Content.RootDirectory);

			//FontSystem fontSystem = FontSystemFactory.Create(GraphicsDevice, 2048, 2048);
			//fontSystem.AddFont(TitleContainer.OpenStream($"{Content.RootDirectory}/font-file.ttf"));

			//GuiHelper.Setup(this, fontSystem);

			//_ui = new IMGUI();

			_ViewportAdapter = new BoxingViewportAdapter(Window, GraphicsDevice, 1600, 1024);
			_Camera = new OrthographicCamera(_ViewportAdapter);

			_spriteBatch = new SpriteBatch(GraphicsDevice);
		}

		//Vector4 mb = new Vector4(0, 5, 0, 0);
		//Vector4 margin = new Vector4(5, 5, 5, 5);
		protected override void Update(GameTime gameTime) {

			Gui.GUI.CleanUp();

			Component.Instantiate<Panel>(1).Bounds(5, 5, 200, 800).Background(Color.Black);

				Component.Instantiate<Panel>(2).Bounds(5, 5, 190, 790).Background(Color.White);

					Component.Instantiate<Panel>(3).Bounds(5, 5, 180, 300);

						Component.Instantiate<Label>(4).Write("My Header.").FontSize(22);
						Component.Instantiate<Label>(5).Write("This is my Label.");
						Component.Instantiate<Button>(6).Write("My Button!").OnSelected();
						Component.Instantiate<Label>(7).Write("This is my Label.");

					Component.Close();

					Component.Instantiate<Panel>(8).Bounds(5, 5, 180, 200);

						Component.Instantiate<Label>(9).Write("My Header.").FontSize(22);
						Component.Instantiate<Label>(10).Write("This is \nmy Label.");
						Component.Instantiate<Label>(11).Write("This is my Error!").FontColor(Color.Red);

					Component.Close();

				Component.Close();

			Component.Close();

			Gui.GUI.Update();

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime) {
			GraphicsDevice.Clear(Color.DarkSlateGray);

			_spriteBatch.Begin(samplerState: SamplerState.PointClamp, blendState: BlendState.AlphaBlend, transformMatrix: _Camera.GetViewMatrix());
			//_CurrentState.Draw(gameTime);
			//_ui.Draw(gameTime);
			_spriteBatch.End();

			_spriteBatch.Begin(samplerState: SamplerState.LinearClamp, transformMatrix: _Camera.GetViewMatrix());
			Gui.GUI.Draw(_spriteBatch);
			_spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}
