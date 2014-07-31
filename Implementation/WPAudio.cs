using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;

namespace GameFramework.Implementation
{
    public class WPAudio : Audio
    {
        #region Fields
        private ContentManager content;
        #endregion
        
        #region Constructors
        public WPAudio(ContentManager content)
        {
            this.content = content;
        }
        #endregion
        
        #region Methods
        public Music NewMusic(string filename)
        {
            Song song = content.Load<Song>(filename);
            return new WPMusic(song);
        }

        public Sound NewSound(string filename)
        {
            SoundEffect effect = content.Load<SoundEffect>(filename);
            return new WPSound(effect);
        }
        #endregion
    }
}
