using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject AndroidUI;

    private void Start()
    {
        Cursor.visible = false;
        if(Application.platform == RuntimePlatform.Android)
        {
            AndroidUI.SetActive(true);
        }
        else
        {
            AndroidUI.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}