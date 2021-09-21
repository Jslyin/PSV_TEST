using UnityEngine;

public class Wood : MonoBehaviour, IDamageble
{
    [SerializeField] private GameObject pref;
    [SerializeField] private Transform spawn;

    private bool hitted = false;
    private void Start()
    {
        pref = Instantiate(pref);
        pref.SetActive(false);
        pref.transform.position = spawn.position;
    }

    public void Hit()
    {
        if (!hitted)
        {
            hitted = true;
            pref.SetActive(true);
        }
     
    }
}
