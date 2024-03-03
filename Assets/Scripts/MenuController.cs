using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void lvScene()
    {
        SceneManager.LoadScene(2);
    }
    public void privatePolicy()
    {
        Application.OpenURL("https://www.privacy-policy-template.com/live.php?token=BdRrp37RqfpAyhRNqBH3ri4dacyByUcP");
    }
    public void info()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
