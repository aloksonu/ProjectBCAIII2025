using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public float speed;

    private int score;
    public TextMeshProUGUI scoreText;

    //public GameManager _gameManager;
    void Start()
    {
        //player.transform.position = new Vector2(5, player.transform.position.y);
        //player.transform.position = new Vector2(player.transform.position.y, 3);

        //player.transform.localScale = new Vector2(3, player.transform.localScale.y);
        //player.transform.localScale = new Vector2(3, 3);

        score = 0;

    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        //float y = Input.GetAxis("Vertical");

        player.transform.Translate(new Vector2(x * Time.deltaTime * speed, 0f));
    }


    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    score++;
    //    scoreText.text = score.ToString();
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        scoreText.text = score.ToString();
        //_gameManager.PlayAudioBunnyCollector(_gameManager.audioClipBunnyColide);
        GameManager.instance.PlayAudioBunnyCollector(GameManager.instance.audioClipBunnyColide);
        Destroy(collision.gameObject);
        //Destroy(gameObject);
    }
}
