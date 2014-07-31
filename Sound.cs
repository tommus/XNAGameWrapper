using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameFramework
{
    public interface Sound
    {
        #region Methods
        /// <summary>
        /// Plays sound file with specified volume.
        /// </summary>
        /// <param name="volume">File playing volume in range from 0.0f (mute) o 1.0f (maximum volume).</param>
        void Play(float volume);

        /// <summary>
        /// Release resources.
        /// </summary>
        void Dispose();
        #endregion
    }
}