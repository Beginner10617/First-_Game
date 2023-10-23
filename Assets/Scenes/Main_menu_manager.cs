using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main_menu_manager : MonoBehaviour
{
    public GameObject instructionsPanel;

    private void Start()
    {
        instructionsPanel.SetActive(false);
    }
    public void Show_instructions()
    {
        instructionsPanel.SetActive(true);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            instructionsPanel.SetActive(false);
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
