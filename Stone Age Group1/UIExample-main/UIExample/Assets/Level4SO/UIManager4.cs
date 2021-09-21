using TMPro;
using UnityEngine;

public class UIManager4 : MonoBehaviour
{
    [SerializeField] private ScoreContainerSO scoreContainer;
    [SerializeField] private TextMeshProUGUI scoreText;

    public void UpdateScore()
    {
        scoreContainer.score++;
        scoreText.text = scoreContainer.score.ToString();
    }
}

