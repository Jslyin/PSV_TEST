using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle3 : MonoBehaviour
{
    private bool isTouch;

    [SerializeField] private LayerMask groundLayer;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (((1 << collision.gameObject.layer) & groundLayer) != 0)
        {
            if (!isTouch)
            {
                UIManager3.Instance.UpdateScore();
                isTouch = true;
            }
        }

    }
}
