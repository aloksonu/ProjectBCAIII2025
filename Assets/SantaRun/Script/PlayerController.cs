using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace SantaRun { 
public class PlayerController : MonoBehaviour
{
        Rigidbody2D rb2d;
        public float jumpForce;
        Animator animator;
        bool canJumpinmg;
        int score;
        public TextMeshProUGUI scoreText;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
    {
            score = 0;
            canJumpinmg = true;
            rb2d = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
            if ((Input.GetMouseButtonDown(0))  && canJumpinmg)
            {
                jump();
                canJumpinmg =false;
            }
            }
        void jump()
        {
            if (!ObstacleSpawner.instance.gameOver)
            {
                rb2d.linearVelocity = Vector2.up * jumpForce;
                score++;
                scoreText.text = score.ToString();
                animator.Play("AnimationJump");
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Ground")
            {
                canJumpinmg = true;
            }

            else if (collision.gameObject.tag == "Enemy")
            {
                ObstacleSpawner.instance.gameOver = true;
            }
        }
      }
    }
