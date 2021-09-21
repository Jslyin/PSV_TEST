using TMPro;
using UnityEngine;

public class UIManager3 : MonoBehaviour
{
    public static UIManager3 Instance { get; private set;}

    [SerializeField] private int score;
    [SerializeField] private TextMeshProUGUI scoreText;


    private void Awake()
    {
        if(Instance==null) // если инстенс не создан
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject); // если случайно создали вторую копию то она удалится
        }
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}

