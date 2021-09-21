using TMPro;
using UnityEngine;

public class UIManager3 : MonoBehaviour
{
    public static UIManager3 Instance { get; private set;}

    [SerializeField] private int score;
    [SerializeField] private TextMeshProUGUI scoreText;


    private void Awake()
    {
        if(Instance==null) // ���� ������� �� ������
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject); // ���� �������� ������� ������ ����� �� ��� ��������
        }
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}

