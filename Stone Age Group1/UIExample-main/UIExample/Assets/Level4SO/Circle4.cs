using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle4 : MonoBehaviour
{
    private bool isTouch;
    private UIManager4 uIManager4;
    [SerializeField] private LayerMask groundLayer;

    private void Start()
    {
        uIManager4 = FindObjectOfType<UIManager4>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (((1 << collision.gameObject.layer) & groundLayer) != 0)
        {
            if (!isTouch)
            {
                uIManager4.UpdateScore();
                isTouch = true;
            }
        }

    }
}
