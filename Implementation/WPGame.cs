using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameFramework.Implementation
{
    public abstract class WPGame : Microsoft.Xna.Framework.Game, GameFramework.Game
    {
        public Screen Screen { get; set; }

        protected GraphicsDeviceManager device;
        protected SpriteBatch spriteBatch;

        protected Audio audio;
        protected Graphics graphics;
        #endregion
        
        #region Properties
        public Audio Audio
        {
            get { return audio; }
        }

        public Graphics Graphics
        {
            get { return graphics; }
        }
        #endregion
        
        #region Constructors
        protected WPGame()
        {
            device = new GraphicsDeviceManager(this);
            SetupDevice(device);

            Content.RootDirectory = "Content";

            TargetElapsedTime = TimeSpan.FromTicks(333333);
            InactiveSleepTime = TimeSpan.FromSeconds(1);
            audio = new WPAudio(Content);
        }
        #endregion
        
        #region Methods
        protected override void Initialize()
        {
            base.Initialize();   
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            graphics = new WPGraphics(device, spriteBatch, Content);

            Screen = GetStartScreen();
        }

        protected override void UnloadContent()
        {
            graphics.Dispose();
            Screen.Dispose();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                Screen.Back();

            base.Update(gameTime);
            Screen.Update(gameTime.ElapsedGameTime.Milliseconds);
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            graphics.Clear(Color.Black);
            spriteBatch.Begin();
            Screen.Draw(gameTime.ElapsedGameTime.Milliseconds);
            spriteBatch.End();
        }
        #endregion
        
        #region To Implement in derrived class
        public abstract Screen GetStartScreen();

        public abstract void SetupDevice(GraphicsDeviceManager device);
        #endregion
    }
}