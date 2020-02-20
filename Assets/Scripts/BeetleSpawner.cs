using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//spawner code brought over from GameJam game 
//all non-commented code came from GameJam game


public class BeetleSpawner : MonoBehaviour
{
    [SerializeField] float waitTime;
    private float timer = 0.0f;



public void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer > waitTime)
        {
            // Remove the recorded 2 seconds.
            spawnTimer = spawnTimer - waitTime;
            Debug.Log("time up");

            for (int i = 0; i < beetlesToclone; i++)
            {
                SpawnBeetle();

            }

        }

        //from old Spawner:
        {
            //position = gameObject.transform.position;
            //rotation = gameObject.transform.rotation;

        }

    }


        public GameObject beetle;
        private Vector3 position;
        Quaternion rotation;
        public float spawnTimer;
        //added spawnPoint to code
        [SerializeField] Transform spawnPoint;
        [SerializeField] float distance;
        [SerializeField] float beetlesToclone = 0;
    public int beetleCount = 0;
    public GameObject spawnPoint2;

    public bool spawnBeetleBool;


    public GameObject target;
    
        public void SpawnBeetle()
        {

        if (beetleCount == 0)
        {
            GameObject clone;
            clone = Instantiate(beetle, spawnPoint.position, spawnPoint.rotation); //added spawnPoint to code
            clone.SetActive(true);
            beetleCount++;
            transform.position = new Vector3(Random.Range(0.1f, 20f), Random.Range(0.1f, 10f), -7);

        }
        if (beetleCount >= 1)
        {

            GameObject clone;

            spawnPoint2 = beetle;
            clone = Instantiate(spawnPoint2, transform.position, transform.rotation); //added spawnPoint to code
            clone.SetActive(true);
            beetleCount++;
            transform.position = new Vector3(Random.Range(0.1f, 20f), Random.Range(0.1f, 10f), -7);

        }


    }


}

