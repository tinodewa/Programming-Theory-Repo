using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Chick : Animal
{
    // POLYMORPHISM
    protected override float defaultSpeed { get { return 5.0f; } }
    // POLYMORPHISM
    protected override float defaultJumpHeight { get { return 0.5f; } }
    
    protected override void CheckActiveAnimal()// POLYMORPHISM
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

