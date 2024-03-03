using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixBackground : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject background;
    // Start is called before the first frame update
    void Start()
    {
        scaleScene();
    }
    void scaleScene()
    {
        float scrHeight = Screen.height;
        float scrWidth = Screen.width;
        float deviceScreen = scrWidth / scrHeight;

        mainCamera.aspect = deviceScreen;
        
        float camHeight = 100 * mainCamera.orthographicSize * 2;
        float camWidth = camHeight*deviceScreen;

        SpriteRenderer backgroundImg = background.GetComponent<SpriteRenderer>();
        float bgImgH = backgroundImg.sprite.rect.height;
        float bgImgW = backgroundImg.sprite.rect.width;

        float scaleHeight = camHeight/bgImgH;
        float scaleWidth = camWidth/bgImgW;

        background.transform.localScale = new Vector3(scaleWidth, scaleHeight, 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
