using BOC_Editor.GenerationInitialization;
using Koko.RunTimeGui;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using MonoGame.Extended.ViewportAdapters;
using System.Collections.Generic;

namespace BOC_Editor {
	public class Editor : Game {

		private IWindowState _CurrentState;

		private readonly GraphicsDeviceManager _graphics;
		private BoxingViewportAdapter _ViewportAdapter;
		private OrthographicCamera _Camera;
		private SpriteBatch _spriteBatch;

		private readonly GUI Gui = GUI.Gui;

		public Editor() {
			_CurrentState = EditorWindowDict.GetState(EditorWindowDict.EWindowType.Overview);

			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}

		protected override void Initialize() {
			_graphics.IsFullScreen = false;
			_graphics.PreferredBackBufferWidth = 1280; // GraphicsDevice.DisplayMode.Width;
			_graphics.PreferredBackBufferHeight = 720; // GraphicsDevice.DisplayMode.Height;
			_graphics.SynchronizeWithVerticalRetrace = false;
			_graphics.ApplyChanges();

			this.IsFixedTimeStep = false;
			FontHelper.Add(Content.RootDirectory);
			Initializer.Init(); // generate all the files into the gui
			GUI.GAME = this; // TODO ew
			Gui.Init(); // call the init on all the generated items

			base.Initialize();
		}

		protected override void LoadContent() {
			_ViewportAdapter = new BoxingViewportAdapter(Window, GraphicsDevice, 1280, 720);
			_Camera = new OrthographicCamera(_ViewportAdapter);
			_spriteBatch = new SpriteBatch(GraphicsDevice);
			GuiHelper.SetUICamera(_Camera);
		}

		protected override void Update(GameTime gameTime)
		{
			Gui.Update(gameTime);
			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime) {
			GraphicsDevice.Clear(Color.DarkSlateGray);

			var view = _Camera.GetViewMatrix();

			//_spriteBatch.Begin(samplerState: SamplerState.PointClamp, blendState: BlendState.AlphaBlend, transformMatrix: view);
			// game logic
			//_spriteBatch.End();

			_spriteBatch.Begin(samplerState: SamplerState.LinearClamp, blendState: BlendState.NonPremultiplied, transformMatrix: view);
			Gui.Draw(_spriteBatch);
			_spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}
