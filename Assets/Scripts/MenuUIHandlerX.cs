using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class MenuUIHandlerX : MonoBehaviour
{
    public TMP_InputField nameInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void SaveName()
    {
        GameManager.Instance.userName = nameInput.GetComponentInChildren<TMP_InputField>().text;
    }

    public string GetUserName()
    {
        return GameManager.Instance.userName;
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

