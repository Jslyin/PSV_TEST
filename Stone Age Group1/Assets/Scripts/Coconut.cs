using UnityEngine;

public class Coconut : MonoBehaviour, IDamageble
{
    [SerializeField] private GameObject egg;
    public void Hit()
    {
        Instantiate(egg).transform.position = transform.position;
        Destroy(gameObject);
    }
}
