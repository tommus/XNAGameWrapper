using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameFramework
{
    public abstract class Screen
    {
        #region Fields
        protected Game game;
        #endregion
        #region Constructors
        public Screen(Game game)
        {
            this.game = game;
        }
        #endregion
        #region Abstracts to implement in derrived classes
        /// <summary>
        /// Here comes all updates such as physics, input handling.
        /// </summary>
        /// <param name="DeltaTime">Time passed since last update.</param>
        public abstract void Update(float DeltaTime);

        /// <summary>
        /// Every game object will be repainted here on every single method call.
        /// </summary>
        /// <param name="DeltaTime">Time passed since last drawing.</param>
        public abstract void Draw(float DeltaTime);

        /// <summary>
        /// Implementing this method allows to handle device back button.
        /// </summary>
        public abstract void Back();

        /// <summary>
        /// Release resources.
        /// </summary>
        public abstract void Dispose();
        #endregion
    }
}