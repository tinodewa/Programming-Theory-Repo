using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooster : Animal
{
    protected override float defaultSpeed { get { return 10.0f; } }

    protected override float defaultJumpHeight { get { return 2.0f; } }
}
