using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick : Animal
{
    protected override float defaultSpeed { get { return 5.0f; } }

    protected override float defaultJumpHeight { get { return 0.5f; } }

    protected override void CheckActiveAnimal()
    {
        GameObject chick = GameObject.Find("Chick");
        if (MainManager.Instance != null)
        {
            if (MainManager.Instance.selectedAnimal != 0)
            {
                chick.SetActive(false);
            }
        }
    }
}

