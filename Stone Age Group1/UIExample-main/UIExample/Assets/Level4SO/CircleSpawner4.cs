using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner4 : MonoBehaviour
{
    [SerializeField] private GameObject circle;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            GameObject gameObject = Instantiate(circle);
            gameObject.transform.position = transform.position;
            yield return new WaitForSeconds(0.05f);
        }
    }
}
