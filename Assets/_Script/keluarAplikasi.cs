using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keluarAplikasi : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
