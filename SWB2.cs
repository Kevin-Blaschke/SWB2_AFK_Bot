using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWB2
{
    public class SWB2 : ScriptBase
    {
        //public static Random rand = new Random();
        /*Constructor */
        public SWB2()
        {

            Config.Name = "SWB2";
            Config.Scenes = new List<Scene>()
            {
                    new Spawn()
            };

        }

        public override void Start()
        {
            base.Start();
        }

        public override void Update()
        {
          
          HandleScenes(); 
          Sleep(5000);
            //int r = rand.Next(0, 256); 
          Press(new DualShockState() { LY = (byte)0}, 5000);
            //Press(new DualShockState() { R2 = 0xff });
          Press(new DualShockState() { Cross = true });
        }
    }
}
