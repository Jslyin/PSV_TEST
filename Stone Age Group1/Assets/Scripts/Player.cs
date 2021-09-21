using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float hungryTick;
    [SerializeField] private float satietyPerTick;
    [SerializeField] private float stunTime;
  

     private int lives = 3;
     private float satiety = 1f;
    private float Satiety
    {
        get => satiety;
        set
        {
            satiety = Mathf.Clamp01( value); 
            Check();
            UI.Satiety = satiety;
        }
    }
    public int Lives
    {
        get => lives;
        set
        {
            lives = value;
            ChangeLives();
        }
    }
    private void Start()
    {
        StartCoroutine(Hungry());
    }
    private IEnumerator Hungry()
    {
        while (true)
        {
            yield return new WaitForSeconds(hungryTick);
            Satiety -= satietyPerTick;
        }
    }
    
    private IEnumerator Stun()
    {
        GameManager.InputEnablet = false;
        Animations.SetBool("stun", true);
        yield return new WaitForSeconds(stunTime);
        Animations.SetBool("stun", false);
        GameManager.InputEnablet = true;
        StartCoroutine(Hungry());
    }
    private void ChangeLives()
    {
        Satiety = 0.5f;
        StopAllCoroutines();
        UI.RemoveHearth(lives);
        if (lives == 0)
        {
            GameManager.InputEnablet = false;
            Animations.SetTrigger("die");
            GameManager.ReloadScene();
        }
        else
        {
            StartCoroutine(Stun());
        }
    }
    public void PickUp(Food food)
    {
        Satiety += food.Satiety;
    }
    private void Check()
    {
        if (satiety <= 0f)
        {
            Lives--;
            
        }
    }
}
