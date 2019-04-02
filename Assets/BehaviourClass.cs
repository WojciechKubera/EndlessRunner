using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public class BehaviourClass
    {
        public static float GetRotation(float horizontalSpeed, float timeDelta, float turnSpeed)
        {
            return horizontalSpeed * timeDelta * turnSpeed;
        }

        public static bool IsGameOver(string tag)
        {
            List<string> deadlyList = new List<string> { "leathal", "barrel", "crate" };
            return deadlyList.Contains(tag);

        }

        public static bool IsCoin(string tag)
        {
            string coinTag = "Coin";
            return coinTag == tag;

        }

        public static bool IsToClean(string tag)
        {
           List<string> tags = new List<string> { "Coin", "emptyP", "crate", "barrel" };
            return tags.Contains(tag);
        }

        public static bool IsMusicNotMute(int volume)
        {
            int mute = 0;
            return volume == mute;
        }
    }
}
    