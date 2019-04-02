using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehaviourClass
{
    public class BehaviourClass
    {
        public static float GetRotation(float horizontalSpeed, float timeDelta, float turnSpeed)
        {
            return horizontalSpeed * timeDelta * turnSpeed;
        }
    }
}
