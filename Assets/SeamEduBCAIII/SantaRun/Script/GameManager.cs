using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public GameObject obstacalePrefab;
    public GameObject[] obstacalePrefab;
    public GameObject gameOverPanel;

    public AudioSource audioSource;
    public AudioClip audioClipBunnyColide;
    public AudioClip audioClipBunnyHealth;


    public static GameManager instance;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //InstantiateObstacale();
        Time.timeScale = 1;
        InvokeRepeating("InstantiateObstacale", 0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InstantiateObstacale()
    {

        int randomCandy = Random.Range(0, obstacalePrefab.Length);
        Instantiate(obstacalePrefab[randomCandy], new Vector2(Random.Range(-8.7f,8.7f), obstacalePrefab[randomCandy].transform.position.y), Quaternion.identity);
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Retry()
    {
        SceneManager.LoadScene("SaveBunny");
    }
    public void RetryCatchBunny()
    {
        SceneManager.LoadScene("CandyCatch");
    }

    public void PlayAudioBunnyCollector(AudioClip _clip)
    {
        audioSource.clip = _clip;
        audioSource.Play();
    }
}
