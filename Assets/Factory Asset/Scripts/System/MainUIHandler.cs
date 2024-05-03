using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUIHandler : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GoBackToPreviousScene();
    }

    private void GoBackToPreviousScene()// ABSTRACTION
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
