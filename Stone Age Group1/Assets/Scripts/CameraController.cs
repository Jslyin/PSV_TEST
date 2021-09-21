using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private Transform min;
    [SerializeField] private Transform max;
    [SerializeField] private Transform cam;
    [SerializeField] private float speed;
    [SerializeField] private float offset = 0.5f;



    private void Update()
    {
        if (Vector2.Distance(cam.position, PlayerInput.Position) > offset)
        {
            ChangePosition();
        }
    }

    private void ChangePosition()
    {
        float x = 0f;
        float y = 0f;
        float t = Time.deltaTime * speed;

        Vector3 playerPos = PlayerInput.Position;

        x = Mathf.Lerp(cam.position.x, playerPos.x, t);
        y = Mathf.Lerp(cam.position.y, playerPos.y, t);

        x = Mathf.Clamp(x, min.position.x, max.position.x);
        y = Mathf.Clamp(y, min.position.y, max.position.y);

        cam.position = new Vector3(x, y, cam.position.z);

        //cam.position = Vector2.Lerp(min.position, PlayerInput.Position, Time.deltaTime * speed) ;

    }

}

//using UnityEngine;

//public class CameraController : MonoBehaviour
//{
//    [SerializeField] private Transform min;
//    [SerializeField] private Transform max;
//    [SerializeField] private Transform cam;
//    [SerializeField] private float speed;

//    private float x = 0f;
//    private float y = 0f;


//    private void Awake()
//    {
//        cam.position = new Vector3(min.position.x, min.position.y, cam.position.z);
//    }

//    private void Update()
//    {
//        if (Vector2.Distance(cam.position, PlayerInput.Position) > 0.5f)
//        {
//            ChangePosition();
//        }
//    }

//    private void ChangePosition()
//    {
//        Vector3 playerPos = PlayerInput.Position;
//        Vector3 pos = cam.position;

//        Vector2 minPos = min.position;
//        Vector2 maxPos = max.position;


//        if (playerPos.x < maxPos.x && playerPos.x > minPos.x)
//        {
//            x += Time.deltaTime * speed;
//            pos.x = Mathf.Lerp(pos.x, playerPos.x, x);
//        }
//        else
//        {
//            x = 0f;
//        }

//        if (playerPos.y < maxPos.y && playerPos.y > minPos.y)
//        {
//            y += Time.deltaTime * speed;
//            pos.y = Mathf.Lerp(pos.y, playerPos.y, y);
//        }
//        else
//        {
//            y = 0f;
//        }

//        cam.position = pos;

//    }

//}