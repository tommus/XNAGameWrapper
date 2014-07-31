using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace GameFramework.Implementation
{
    public class WPSound : Sound
    {
        #region Fields
        private SoundEffect effect;
        #endregion
        
        #region Constructors
        public WPSound(SoundEffect effect)
        {
            this.effect = effect;
        }
        #endregion
        
        #region Methods
        public void Play(float volume)
        {
            effect.Play(volume, 0.0f, 0.0f);
        }

        public void Dispose()
        {
            effect.Dispose();
        }
        #endregion
    }
}