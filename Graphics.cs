using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameFramework
{
    public interface Graphics
    {
        #region Fields
        /// <summary>
        /// Returns screen width.
        /// </summary>
        int Width { get; }

        /// <summary>
        /// Returns screen width divided by two (usefull for positioning purposes).
        /// </summary>
        int HalfWidth { get; }

        /// <summary>
        /// Returns screen height.
        /// </summary>
        int Height { get; }

        /// <summary>
        /// Returns screen height divided by two (usefull for positioning purposes).
        /// </summary>
        int HalfHeight { get; }
        #endregion
        #region Methods
        /// <summary>
        /// Creates an object of Image class from file.
        /// </summary>
        /// <param name="filename">Path to image file from Contents directory.</param>
        /// <returns>An object of Image class.</returns>
        Image NewImage(String filename);

        /// <summary>
        /// Loads font from file.
        /// </summary>
        /// <param name="filename">Path to font file from Contents directory.</param>
        /// <returns>An object of SpriteFont class.</returns>
        SpriteFont NewFont(String filename);

        /// <summary>
        /// Draws image passed as parameter on the screen.
        /// </summary>
        /// <param name="image">An image object to draw on the screen.</param>
        void DrawImage(Image image);

        /// <summary>
        /// Draws image passed as parameter on the screen at specified location (from upper left screen corner).
        /// </summary>
        /// <param name="image">An image object to draw on the screen.</param>
        /// <param name="x">X-position relative from the left of the screen.</param>
        /// <param name="y">Y-position relative from the top of the screen.</param>
        void DrawImage(Image image, int x, int y);

        /// <summary>
        /// Draws image passed as parameter on the screen at specified location (from upper left screen corner) and
        /// specified image width and height. Usefull while drawing part of an image (i.e. from spritesheet).
        /// </summary>
        /// <param name="image">An image object to draw on the screen.</param>
        /// <param name="x">X-position relative from the left of the screen.</param>
        /// <param name="y">Y-position relative from the top of the screen.</param>
        /// <param name="width">Image width.</param>
        /// <param name="height">Image height.</param>
        void DrawImage(Image image, int x, int y, int width, int height);

        /// <summary>
        /// Draws image passed as parameter on the screen at specified location (from upper left screen corner) and
        /// specified background color (or transparency).
        /// </summary>
        /// <param name="image">An image object to draw on the screen.</param>
        /// <param name="x">X-position relative from the left of the screen.</param>
        /// <param name="y">Y-position relative from the top of the screen.</param>
        /// <param name="color">Background color.</param>
        void DrawImage(Image image, int x, int y, Color color);

        /// <summary>
        /// Draws image passed as parameter on the screen at specified location (from upper left screen corner) and
        /// specified image width and height. Usefull while drawing scaled image. While not respecting image ratio
        /// it will be stretched.
        /// </summary>
        /// <param name="image">An image object to draw on the screen.</param>
        /// <param name="x">X-position relative from the left of the screen.</param>
        /// <param name="y">Y-position relative from the top of the screen.</param>
        /// <param name="scaledWidth">Target image width.</param>
        /// <param name="scaledHeight">Target image height.</param>
        void DrawScaledImage(Image image, int x, int y, int scaledWidth, int scaledHeight);

        /// <summary>
        /// Draws text at specified location (from upper left screen corner) and specified color.
        /// </summary>
        /// <param name="font">Font which will be used for drawing text.</param>
        /// <param name="text">Text string to draw.</param>
        /// <param name="x">X-position relative from the left of the screen.</param>
        /// <param name="y">Y-position relative from the top of the screen.</param>
        /// <param name="color">Text color (or transparency).</param>
        void DrawString(SpriteFont font, String text, int x, int y, Color color);

        /// <summary>
        /// Draws scaled text at specified location (from upper left screen corner) and specified color.
        /// </summary>
        /// <param name="font">Font which will be used for drawing text.</param>
        /// <param name="text">Text string to draw.</param>
        /// <param name="x">X-position relative from the left of the screen.</param>
        /// <param name="y">Y-position relative from the top of the screen.</param>
        /// <param name="scale">Font scale.</param>
        /// <param name="color">Text color (or transparency).</param>
        void DrawString(SpriteFont font, String text, int x, int y, float scale, Color color);

        /// <summary>
        /// Fills screen with specified color.
        /// </summary>
        /// <param name="color">Color to fill screen.</param>
        void Clear(Color color);

        /// <summary>
        /// Release resources.
        /// </summary>
        void Dispose();
        #endregion
    }
}