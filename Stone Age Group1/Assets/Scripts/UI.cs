using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    private static UI ui;

    [SerializeField] private Image healthBar;
    [SerializeField] private Image[] icons;

    public static float Satiety
    {
        set
        {
            ui.healthBar.fillAmount = value;
            ui.healthBar.color = Color.Lerp(Color.red, Color.green, value);
        }
    }

    //public static void SetValue(float value)
    //{
    //    ui.healthBar.fillAmount = value;
    //}

    private void Awake()
    {
        ui = this;
    }

    public static void RemoveHearth(int i)
    {
        ui.icons[i].color = Color.gray;

    }
   
}
