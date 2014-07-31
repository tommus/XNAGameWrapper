using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace GameFramework
{
    public interface Image
    {
        #region Properties
        /// <summary>
        /// Returns an image width.
        /// </summary>
        int Width { get; }

        /// <summary>
        /// Returns an image height.
        /// </summary>
        int Height { get; }

        /// <summary>
        /// Returns an image texture.
        /// </summary>
        Texture2D Texture { get; }
        #endregion
        #region Methods
        /// <summary>
        /// Release resources.
        /// </summary>
        void Dispose();
        #endregion
    }
}