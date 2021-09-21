using UnityEngine;

public class Animations : MonoBehaviour
{
    private static Animations inst;
    private static Animator target => inst.anim;
    [SerializeField] private Animator anim;
   

    private void Awake()
    {
        inst = this;
    }


  public static void SetBool(string name, bool value)
    {

        target.SetBool(name, value);
    }
    public static void SetTrigger(string name)
    {
        target.SetTrigger(name);
    }

}
