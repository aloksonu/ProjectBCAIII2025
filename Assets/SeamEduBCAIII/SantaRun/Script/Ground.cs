using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Ground : MonoBehaviour
{
    public GameObject[] healthOBJ;
    private int health;

    //public GameManager _gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = 3;
       // healthOBJ[0].SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        if (health > 0) { 
        healthOBJ[3 - health].SetActive(false);
            //_gameManager.PlayAudioBunnyCollector(_gameManager.audioClipBunnyHealth);
            GameManager.instance.PlayAudioBunnyCollector(GameManager.instance.audioClipBunnyHealth);
            health--;
            if (health == 0) {
                //_gameManager.GameOver();
                GameManager.instance.GameOver();
            }
        }
    }
}
