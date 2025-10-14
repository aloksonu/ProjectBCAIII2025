using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public static ObstacleSpawner instance;
    public GameObject[] obstacles;
    public bool gameOver;
    //public GameObject spawanPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        //InvokeRepeating(nameof(SpawnObstacle), 0, 3);
        //StartCoroutine(nameof(Spawn));
        gameOver = false;
        StartCoroutine("Spawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void SpawnObstacle()
    //{
    //    int random = Random.Range(0, obstacles.Length);
    //    Instantiate(obstacles[random], this.transform.position, Quaternion.identity);
    //}

    IEnumerator Spawn()
    {
        while (!gameOver)
        {
            float time = Random.Range(1f,1.5f);
            int random = Random.Range(0, obstacles.Length);
            Instantiate(obstacles[random], this.transform.position, Quaternion.identity);
            //Debug.Log(time);
            yield return new WaitForSeconds(time);
        }
    }
}
