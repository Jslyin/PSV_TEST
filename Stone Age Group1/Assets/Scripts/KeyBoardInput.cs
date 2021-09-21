using UnityEngine;
using UnityEngine.Events;

public class KeyBoardInput : MonoBehaviour
{
    [SerializeField] UnityEvent d_Press;
    [SerializeField] UnityEvent d_Up;

    [SerializeField] UnityEvent a_Press;
    [SerializeField] UnityEvent a_Up;

    [SerializeField] UnityEvent jump_Press;
    [SerializeField] UnityEvent hit_Press;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            d_Press.Invoke();
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            d_Up.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            a_Press.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            a_Up.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump_Press.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            hit_Press.Invoke();
        }
    }

}
