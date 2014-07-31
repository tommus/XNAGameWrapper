using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace GameFramework
{
    public interface Game
    {
        #region Properties
        /// <summary>
        /// Audio manager handler. Every game must have this manager to create and play music and sound files.
        /// </summary>
        Audio Audio { get; }

        /// <summary>
        /// Graphics manager handler.
        /// </summary>
        Graphics Graphics { get; }

        /// <summary>
        /// Instantiates logically separated screen, such as menu screen, main game screen, scores screen, etc.
        /// Check for details Screen class.
        /// </summary>
        Screen Screen { get; set; }
        #endregion
        #region Abstracts to implement in derrived classes
        /// <summary>
        /// Every game must implement this method. It should return first Screen object (mostly splash or menu screen).
        /// </summary>
        /// <returns>An object of Screen class.</returns>
        Screen GetStartScreen();

        /// <summary>
        /// Allows to configure device parameters, such as device screen size, sensors, etc.
        /// </summary>
        /// <param name="device">Device manager object for configuration purposes.</param>
        void SetupDevice(GraphicsDeviceManager device);
        #endregion
    }
}