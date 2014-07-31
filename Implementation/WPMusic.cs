using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Media;

namespace GameFramework.Implementation
{
    public class WPMusic : Music
    {
        #region Fields
        private Song song;
        #endregion
        
        #region Properties
        public Boolean IsPlaying
        {
            get
            {
                return (MediaPlayer.State == MediaState.Playing);
            }
        }

        public Boolean IsStopped
        {
            get
            {
                return (MediaPlayer.State == MediaState.Stopped);
            }
        }

        public bool IsLooping
        {
            get
            {
                return MediaPlayer.IsRepeating;
            }
        }
        #endregion
        
        #region Constructors
        public WPMusic(Song song)
        {
            this.song = song;
        }
        #endregion
        
        #region Methods
        public void Play()
        {
            if (MediaPlayer.State == MediaState.Playing)
                return;

            MediaPlayer.Play(song);
        }

        public void Pause()
        {
            if (MediaPlayer.State == MediaState.Playing)
                MediaPlayer.Pause();
        }

        public void Resume()
        {
            if (MediaPlayer.State == MediaState.Paused)
                MediaPlayer.Resume();
            if (MediaPlayer.State == MediaState.Stopped)
		Play();
        }
        
        public void Stop()
        {
            if (MediaPlayer.State == MediaState.Playing)
                MediaPlayer.Stop();
        }

        public void SetLooping(bool looping)
        {
            MediaPlayer.IsRepeating = looping;
        }

        public void SetVolume(float volume)
        {
            MediaPlayer.Volume = volume;
        }

        public void Dispose()
        {
            song.Dispose();
        }
        #endregion
    }
}