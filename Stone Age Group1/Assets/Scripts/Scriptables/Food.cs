using UnityEngine;
[CreateAssetMenu(fileName = "Food", menuName = "JS/Add Food")]
public class Food : ScriptableObject
{
    [SerializeField] private float satiety;
    public float Satiety => satiety;





}
