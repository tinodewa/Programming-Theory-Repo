using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEditor;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    private void Start()
    {
        MainManager.Instance.selectedAnimal = dropdown.value;
    }

    public void DropDownValueChanged()
    {
        MainManager.Instance.selectedAnimal = dropdown.value;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

}
