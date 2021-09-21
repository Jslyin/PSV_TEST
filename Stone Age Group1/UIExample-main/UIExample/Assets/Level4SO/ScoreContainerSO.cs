using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreContainer", menuName = "ScriptableObjects/ScoreContainer", order = 1)]
public class ScoreContainerSO : ScriptableObject
{
    public int score;
     
    private void OnEnable()
    {
        score = 0;
    }
}
