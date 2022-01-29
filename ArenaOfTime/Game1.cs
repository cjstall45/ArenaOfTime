using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ArenaOfTime
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private SpriteFont retroGaming;
        private KnightSprite knightSprite;
        private NinjaSprite ninjaSprite;
        private PersianSprite persianSprite;
        private VikingSprite vikingSprite;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.GraphicsProfile = GraphicsProfile.HiDef;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            knightSprite = new KnightSprite();
            ninjaSprite = new NinjaSprite();
            persianSprite = new PersianSprite();
            vikingSprite = new VikingSprite();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            knightSprite.LoadContent(Content);
            ninjaSprite.LoadContent(Content);
            persianSprite.LoadContent(Content);
            vikingSprite.LoadContent(Content);
            retroGaming = Content.Load<SpriteFont>("retroGaming");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            knightSprite.Draw(gameTime, spriteBatch);
            ninjaSprite.Draw(gameTime, spriteBatch);
            persianSprite.Draw(gameTime, spriteBatch);
            vikingSprite.Draw(gameTime, spriteBatch);
            spriteBatch.DrawString(retroGaming, "Arena of Time", new Vector2(140, 50), Color.Red);
            spriteBatch.DrawString(retroGaming, "Press escape to close", new Vector2(280, 440), Color.Red, 0, new Vector2(0, 0), .25f, SpriteEffects.None, 0);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
