using UnityEngine;
using TMPro;

public class ScoreTrigger : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score = 0;

    private void Start()
    {
        scoreText.text = "Scor: 0";
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            score++;
            scoreText.text = "Scor: " + score;
        }
    }
}
