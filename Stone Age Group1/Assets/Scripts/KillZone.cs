using UnityEngine;

public class KillZone : MonoBehaviour
{
    [SerializeField] private bool isNextLv = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        Player p = other.GetComponent<Player>();
        if(p != null)
        {
            if (isNextLv)
            {
                GameManager.NexLevel(); 
            }
            p.Lives--;
            GameManager.ResetPlayerPos();
        }
        
    }






}
