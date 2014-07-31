using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameFramework
{
    public interface Music
    {
        #region Properties
        /// <summary>
        /// Returns true when music file is being played, otherwise returns false.
        /// </summary>
        Boolean IsPlaying { get; }

        /// <summary>
        /// Returns true when music file is not being called, otherwise returns false.
        /// </summary>
        Boolean IsStopped { get; }

        /// <summary>
        /// Returns true when music file will be played in loop, otherwise returns false.
        /// </summary>
        Boolean IsLooping { get; }
        #endregion
        #region Methods
        /// <summary>
        /// Allows to play audio file. Only one music file can be played in the same time.
        /// </summary>
        void Play();

        /// <summary>
        /// Pauses music playing. 
        /// </summary>
        void Pause();
        
        /// <summary>
        /// Resumes music playing. If Stop() method used before it starts file playing from begining.
        /// </summary>
        void Resume();

        /// <summary>
        /// Stops music playing.
        /// </summary>
        void Stop();

        /// <summary>
        /// After invoking method with argument looping set to true, music file will be played in loop.
        /// </summary>
        /// <param name="looping">To start playing music file in loop, use true, otherwise false.</param>
        void SetLooping(Boolean looping);

        /// <summary>
        /// Sets music playing volume.
        /// </summary>
        /// <param name="volume">Use range from 0.0f (mute) to 1.0f (maximum volume).</param>
        void SetVolume(float volume);

        /// <summary>
        /// Release resources.
        /// </summary>
        void Dispose();
        #endregion
    }
}
