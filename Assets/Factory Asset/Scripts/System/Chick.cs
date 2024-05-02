using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick : Animal
{
    protected override float defaultSpeed { get { return 5.0f; } }

    protected override float defaultJumpHeight { get { return 0.5f; } }
}

