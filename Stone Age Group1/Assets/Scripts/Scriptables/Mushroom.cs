using UnityEngine;

public class Mushroom : FoodPickUp
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PickUp(collision);
        GameManager.CanWin = true;
    }


}
