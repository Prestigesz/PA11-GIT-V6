using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject[] SpawnObject;
    float PositionY;
    private int SpawnPoints;
    private float spawntime = 1f;
    private float spawndelay = 2f;
    private int randomInt;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", spawntime, spawndelay);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        randomInt = Random.Range(0, SpawnObject.Length);
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObject[randomInt], transform.position, transform.rotation);

        //Instantiate(SpawnObject, SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
    }
}
