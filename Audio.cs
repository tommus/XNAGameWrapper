using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameFramework
{
    public interface Audio
    {
        /// <summary>
        /// Creates an object of Music class, which allows to create and play musics.
        /// Only one music file can be played at the same time.
        /// </summary>
        /// <param name="filename">Music file path from Contents directory.</param>
        /// <returns>An object of Music class.</returns>
        Music NewMusic(String filename);

        /// <summary>
        /// Creates an object of Sound class, which allows to create and play sounds.
        /// </summary>
        /// <param name="filename">Sound file path from Contents directory.</param>
        /// <returns>An object of Sound class.</returns>
        Sound NewSound(String filename);
    }
}
