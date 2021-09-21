using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager gm;
    
    [SerializeField] private Transform playerSpawn;
    [SerializeField] private string sceneName;
    [SerializeField] private string nextLevelName;

    public static bool CanWin {get; set;}


    private void Start()
    {
        gm = this;
        ResetPlayerPos();
    }
    public static void ResetPlayerPos()
    {
      PlayerInput.Position = gm.playerSpawn.position;
    }
    public static void ReloadScene()
    {
      gm.StartCoroutine(Reload());
    }
    private static IEnumerator Reload()
    {
        yield return new WaitForSeconds(2f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(gm.sceneName);
    }
    public static bool InputEnablet
    {
        set
        {
            if(value == true)
            {
                PlayerInput.Enable();
            }
            else
            {
                PlayerInput.Disable();
            }
        }
    }

   public static void NexLevel()
    {
        if (CanWin)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(gm.nextLevelName);
        }
    }
}
