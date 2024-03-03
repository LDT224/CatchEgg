using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    //Set time and number chicken
    public void easy()
    {
        PlayerPrefs.SetFloat("MaxSpawn", 2);
        PlayerPrefs.SetFloat("MinSpawn", 3);
        PlayerPrefs.SetInt("NumChicken", 5);
    }
    public void normal()
    {
        PlayerPrefs.SetFloat("MaxSpawn", 1);
        PlayerPrefs.SetFloat("MinSpawn", 2);
        PlayerPrefs.SetInt("NumChicken", 9);
    }
    public void hard()
    {
        PlayerPrefs.SetFloat("MaxSpawn", 0.5f);
        PlayerPrefs.SetFloat("MinSpawn", 1);
        PlayerPrefs.SetInt("NumChicken", 13);
    }
    public void loadGame()
    {
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
