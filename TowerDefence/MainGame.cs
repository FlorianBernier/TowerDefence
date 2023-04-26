using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace TowerDefence
{
    public class MainGame : Game
    {
        public static SpriteBatch spriteBatch;
        public static ContentManager content;
        public static SpriteFont font;

        public GraphicsDeviceManager graphics;
        public MainGameTD mainGameTD;

        public static Texture2D mouseTransparent;

        List<Monster> monsters;
        public MainGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            content = Content;

            IsMouseVisible = true;
            graphics.PreferredBackBufferWidth = 1920;
            graphics.PreferredBackBufferHeight = 1010;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            mainGameTD = new MainGameTD();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            font = Content.Load<SpriteFont>("MyFont");

            // TODO: use this.Content to load your game content here
            mainGameTD.LoadContent();

            mouseTransparent = new Texture2D(GraphicsDevice, 1, 1);
            mouseTransparent.SetData(new[] { Color.Transparent });
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            mainGameTD.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here

            spriteBatch.Begin();

            mainGameTD.Draw();

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}