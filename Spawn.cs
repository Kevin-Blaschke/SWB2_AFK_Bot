using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWB2
{
    class Spawn : Scene
    {
        public override string Name => "Spawn Screen";

        public static RectMap key = new RectMap()
        {
            X = 61,
            Y = 538,
            Width = 85,
            Height = 151,
            Hash = 18410856686823440512
        };

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(key, 50);
        }

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { Cross = true });
        }
    }
}
