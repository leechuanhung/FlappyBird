
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    AudioSource audioSource;
    public float JumpPower;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * JumpPower;
            audioSource.Play();
        }
       if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * JumpPower;
            audioSource.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("GameOverScene");
        if(Score.score > Score.bestscore)
        {
            Score.bestscore = Score.score;
        }
    }
}
