using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChicken : MonoBehaviour
{
    public GameObject chicken;
    public GameObject[] spawnPoint;
    public GameObject egg;
    public GameObject shit;
    private List<GameObject> chickenList = new List<GameObject>();
    private List<int> pointList = new List<int>();
    public float minSpawnTime ;
    public float maxSpawnTime ;
    private float lastSpawnTime = 0;
    private float spawnTime = 0;
    private int point;
    public int numChicken;
    // Start is called before the first frame update
    void Start()
    {
        //Get time spawn, number chicken, spawn chicken, update time spawn egg
        minSpawnTime = PlayerPrefs.GetFloat("MinSpawn", 0);
        maxSpawnTime = PlayerPrefs.GetFloat("MaxSpawn", 0);
        numChicken = PlayerPrefs.GetInt("NumChicken",0);
        updateSpawnEgg();
        spawnChicken();

    }
    void spawnChicken()
    {
        //spawn "numChicken" chickens
        for(int i = 0; i < numChicken; i++)
        {
            point = Random.Range(0, spawnPoint.Length);
            checkPoint();
            pointList.Add(point);
            GameObject chick = Instantiate(chicken, spawnPoint[point].transform.position, Quaternion.identity);
            chickenList.Add(chick);
        }
    }
    void checkPoint()
    {
        //Check spawn point
        //New point != list old point
        for(int j = 0; j < pointList.Count; j++)
        {
            if(point == pointList[j])
            {
                point = Random.Range(0, spawnPoint.Length);
                checkPoint();
                break;
            }
        }

    }
    void updateSpawnEgg()
    {
        //Update time spawn next egg, random spawn time
        lastSpawnTime = Time.time;
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }
    void spawnEgg()
    {
        //Random chickenList[i] spawn egg
        int i = Random.Range(0, chickenList.Count);
        //Random shit or egg
        int ran = Random.Range(0, 5);
        //Spawn shit/egg at child position
        if (ran == 0)
        {
            Instantiate(shit, chickenList[i].transform.GetChild(0).position, Quaternion.identity);
        }
        else
        {
            Instantiate(egg, chickenList[i].transform.GetChild(0).position, Quaternion.identity);
        }
        //Update time spawn
        updateSpawnEgg();
    }
    // Update is called once per frame
    void Update()
    {
        //Calculate time spawn
        if (Time.time >= lastSpawnTime + spawnTime)
        {
            spawnEgg();
        }
    }
}
