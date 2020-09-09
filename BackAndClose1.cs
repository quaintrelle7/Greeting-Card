using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackAndClose1 : MonoBehaviour
{
  public void BackButton()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void CloseButton()
        {
            Application.Quit();
            Debug.Log("Exit button is pressed");
            //Debug.Log("klsk");
        }
}
