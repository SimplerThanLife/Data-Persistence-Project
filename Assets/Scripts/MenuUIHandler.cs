using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.Build;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif


[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField NameInputField;

    public void NewNameInputted(string name)
    {
        MainManager.Instance.playerName = name;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void OnSubmit()
    {
        string enteredName = NameInputField.text;

        Debug.Log("Entered Name:" + enteredName);
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
