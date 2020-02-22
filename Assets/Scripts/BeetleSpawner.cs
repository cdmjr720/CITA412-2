using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Beetle.Action;
using Beetle.SceneManagement;
using UnityEngine.SceneManagement;
using Beetle.Count;



namespace Beetle.Spawn
{
    public class BeetleSpawner : MonoBehaviour
    {
        private bool pressed = false;
        [SerializeField] float waitTime;
        private float timer = 0.0f;
        public GameObject beetle;
        public float spawnTimer;
        [SerializeField] float beetlesToclone = 0;
        public int beetleCount;
        public GameObject spawnPoint;
        
        public void Start()
        {
//            beetleCount = FindObjectOfType<Score>().beetleCount;
        }
        
        public void Update()
        {
            
            spawnTimer += Time.deltaTime;
            if (spawnTimer > waitTime)
            {
                spawnTimer = spawnTimer - waitTime;
//                Debug.Log(beetleCount);

                for (int i = 0; i < beetlesToclone; i++)
                {
                    SpawnBeetle();

                }
            }
        }

        public void SpawnBeetle()
        {
          
            if (beetleCount >= 0)
            {
                GameObject clone;

                spawnPoint = beetle;
                clone = Instantiate(spawnPoint, transform.position, transform.rotation); //added spawnPoint to code
                clone.SetActive(true);
                beetleCount++;
//                Debug.Log(beetleCount);
                transform.position = new Vector3(Random.Range(0.1f, 20f), Random.Range(0.1f, 10f), -7);
            }
        }
    }
}

