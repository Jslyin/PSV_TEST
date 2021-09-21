using TMPro;
using UnityEngine;

public class UIManager2 : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private TextMeshProUGUI scoreText;

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}

