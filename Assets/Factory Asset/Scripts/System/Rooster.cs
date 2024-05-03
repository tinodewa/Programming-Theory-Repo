using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooster : Animal
{
    protected override float defaultSpeed { get { return 10.0f; } }

    protected override float defaultJumpHeight { get { return 2.0f; } }

    protected override void CheckActiveAnimal()
    {
        GameObject rooster = GameObject.Find("Rooster");

        if (MainManager.Instance != null)
        {
            if (MainManager.Instance.selectedAnimal != 1)
            {
                rooster.SetActive(false);
            }
        }
    }
}
