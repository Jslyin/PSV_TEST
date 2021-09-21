using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private List<IDamageble> targets = new List<IDamageble>();


    private void OnTriggerEnter2D(Collider2D other)
    {
        IDamageble damageble = other.GetComponent<IDamageble>();
        if (damageble != null)
        {
            targets.Add(damageble);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        IDamageble damageble = other.GetComponent<IDamageble>();
        if (damageble != null)
        {
            targets.Remove(damageble);
        }
    }
    public void Hit()
    {
        for (int i = 0; i < targets.Count; i++)
        {
            targets[i].Hit();
        }
    }
}
