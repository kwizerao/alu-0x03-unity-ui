using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Material trapMat;
    public Material goalMat;
    public Toggle colorblindMode;

    public void PlayMaze()
    {
        // Reset to original colors
        trapMat.color = new Color32(255, 0, 0, 255); // Red
        goalMat.color = new Color32(0, 255, 0, 255); // Green

        // Apply colorblind settings if needed
        if (colorblindMode != null && colorblindMode.isOn)
        {
            trapMat.color = new Color32(255, 112, 0, 255); // Orange
            goalMat.color = Color.blue; // Blue
        }

        // Load the maze scene
        SceneManager.LoadScene("maze");
    }

    public void QuitMaze()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}