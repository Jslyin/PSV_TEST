using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner3 : MonoBehaviour
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
            yield return new WaitForSeconds(0.1f);
        }
    }
}
