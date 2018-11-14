using System;
using IrrKlang;

namespace Graphics2D
{
    class Sound
    {
        #region Class Parameters
        // Creates the sound engine
        ISoundEngine engine = new ISoundEngine();
        #endregion

        #region Class Constructors
        /// <summary>
        /// Default sound constructor
        /// </summary>
        public Sound() {}
        #endregion

        #region Class Methods
        /// <summary>
        /// Play the sound clip once
        /// </summary>
        public void Play()
        {
            engine.Play2D(@"C:\Users\Admin\Desktop\Graphics2D\Graphics2D\sound.wav", false);
        }
        #endregion
    }
}