using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch14_P2_CarLibrary
{
    public enum MusicMedia
    {
        musicCd, // 0
        musicTape, // 1
        musicRadio, // 2
        musicMp3 // 3
    }

    // Represents the state of the engine.
    public enum EngineState
    { engineAlive, engineDead }
    
    // The abstract base class in the hierarchy.
    public abstract class Car
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        protected EngineState egnState = EngineState.engineAlive;
        public EngineState EngineState => egnState;
        public abstract void TurboBoost();
        public Car() { }
        public Car(string name, int maxSp, int currSp)
        {
            PetName = name; MaxSpeed = maxSp; CurrentSpeed = currSp;
        }

        public void TurnOnRadio(bool musicOn ,MusicMedia mm )
        {
            MessageBox.Show("radio working...");
        }

    }
}
