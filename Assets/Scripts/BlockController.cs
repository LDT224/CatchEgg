using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    private GameObject basketController;
    private GameObject gameController;
    // Start is called before the first frame update
    void Start()
    {
        basketController = GameObject.FindGameObjectWithTag("Player");
        gameController = GameObject.FindGameObjectWithTag("GameController");
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        //Destroy old egg/shit
        Destroy(other.gameObject);
        //Check egg, check lose and destroy heart
        if (other.gameObject.CompareTag("egg"))
        {
            basketController.GetComponent<BasketController>().count++;
            if (basketController.GetComponent<BasketController>().count == 2)
            {
                gameController.GetComponent<GameController>().lose();
            }
            Destroy(basketController.GetComponent<BasketController>().heart[basketController.GetComponent<BasketController>().count]);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
