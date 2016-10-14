using UnityEngine;
using System.Collections;

public class ManagerScript : MonoBehaviour
{
    public GameObject snakeObj;
    GameObject snake_h;
    float scl, xspeed, yspeed;
    public Vector2 camWidth, camHeight; //x = min, y = max
    // Use this for initialization
    void Start()
    {
        
        snakeObj.transform.position = new Vector2(0, 0);
        scl = 0.125f;
        Debug.Log(Camera.main.pixelWidth);
        //xspeed = Camera.main.pixelWidth / scl;
        //yspeed = Camera.main.pixelHeight / scl;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {

        }
    }
    void MoveSnake()
    {   
        snakeObj.transform.position = new Vector2(Mathf.Clamp(snakeObj.transform.position.x, -4.86f, 4.86f), Mathf.Clamp(snakeObj.transform.position.y, -2.68f, 2.68f));
        snakeObj.transform.Translate(new Vector3(scl, 0, 0));

    }
}
