using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextGame : MonoBehaviour
{
    public GameObject InputName=null;
  
   
  

    public void PlayGame()
    {
        string a = InputName.GetComponent<Text>().text;


        PlayerPrefs.SetString("name", a);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
}
