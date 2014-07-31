using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace GameFramework.Implementation
{
    public class WPGraphics : Graphics
    {
        #region Fields
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private ContentManager content;
        #endregion
        
        #region Properties
        public int Width
        {
            get { return spriteBatch.GraphicsDevice.Viewport.Width; }
        }

        public int HalfWidth
        {
            get { return Width / 2; }
        }

        public int Height
        {
            get { return spriteBatch.GraphicsDevice.Viewport.Height; }
        }

        public int HalfHeight
        {
            get { return Height / 2; }
        }
        #endregion
        
        #region Constructors
        public WPGraphics(GraphicsDeviceManager graphics, SpriteBatch spriteBatch, ContentManager content)
        {
            this.graphics = graphics;
            this.spriteBatch = spriteBatch;
            this.content = content;
        }
        #endregion
        
        #region Methods
        public void Clear(Color color)
        {
            spriteBatch.GraphicsDevice.Clear(color);
        }

        public void Dispose()
        {
            spriteBatch.Dispose();
        }

        public Image NewImage(String filename)
        {
            Texture2D image = content.Load<Texture2D>(filename);
            return new WPImage(image);
        }

        public SpriteFont NewFont(String filename)
        {
            return content.Load<SpriteFont>(filename);
        }

        public void DrawImage(Image image)
        {
            Texture2D texture = image.Texture;
            spriteBatch.Draw(texture, Vector2.Zero, Color.White);
        }

        public void DrawImage(Image image, int x, int y, Color color)
        {
            Texture2D texture = image.Texture;
            spriteBatch.Draw(texture, new Vector2(x, y), color);
        }
        
        public void DrawImage(Image image, int x, int y)
        {
            Texture2D texture = image.Texture;
            spriteBatch.Draw(texture, new Vector2(x, y), Color.White);
        }

        public void DrawImage(Image image, int x, int y, int width, int height)
        {
            Texture2D texture = image.Texture;
            spriteBatch.Draw(texture, new Vector2(x, y), new Rectangle(0, 0, width, height), Color.White);
        }
        
        public void DrawScaledImage(Image image, int x, int y, int scaledWidth, int scaledHeight)
        {
            Texture2D texture = image.Texture;
            spriteBatch.Draw(texture, new Rectangle(x, y, scaledWidth, scaledHeight), null, Color.White);
        }

        public void DrawString(SpriteFont font, String text, int x, int y, Color color)
        {
            spriteBatch.DrawString(font, text, new Vector2(x, y), color);
        }

        public void DrawString(SpriteFont font, String text, int x, int y, float scale, Color color)
        {
            spriteBatch.DrawString(font, text, new Vector2(x, y), color, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
        }
        #endregion
    }
}