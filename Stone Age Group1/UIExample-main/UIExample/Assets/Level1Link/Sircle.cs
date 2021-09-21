using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sircle : MonoBehaviour
{
    [SerializeField] private LayerMask groundLayer;

    private UIManager uIManager;
    private bool isTouch;
    private int i;

    public void SetUIManager(UIManager uIManager, int i)
    {
        this.uIManager = uIManager;
        this.i = i;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (((1 << collision.gameObject.layer) & groundLayer) != 0)
        {
            if (!isTouch)
            {
                uIManager.UpdateScore(i);
                isTouch = true;
            }
        }
    }
}
