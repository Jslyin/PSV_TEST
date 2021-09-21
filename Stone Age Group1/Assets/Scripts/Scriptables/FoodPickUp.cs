using UnityEngine;

public class FoodPickUp : MonoBehaviour
{
    [SerializeField] private Food data;


    private void OnTriggerEnter2D(Collider2D other)
    {
        PickUp(other);
    }

   protected void PickUp(Collider2D other)
    {
        Player pl = other.GetComponent<Player>();
        if (pl)
        {
            pl.PickUp(data);
            Destroy(gameObject);
        }
    }
}
