using UnityEngine;
using System.Collections;

public class ManagerScript : MonoBehaviour
{
    public GameObject snakeObj;
    private GameObject cam;
    GameObject snake_h;
    float scl, xspeed, yspeed;
    Vector2 camWidth = new Vector2(0.195f,8.7f);//x is min, y is max
    Vector2 camHeight = new Vector2(0.19f,4.81f);
    Vector2 dir = new Vector2(1,0);
    Vector2 snakePos;
    // Use this for initialization
    void Start()
    {
        //scl = 0.125f;
        //Debug.Log(Camera.main.pixelWidth);
        //xspeed = Camera.main.pixelWidth / scl;
        //yspeed = Camera.main.pixelHeight / scl;

        snakePos = snakeObj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            dir = new Vector2(0,1);
        }else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            dir = new Vector2(0,-1);
        }else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            dir = new Vector2(-1,0);
        }else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            dir = new Vector2(1,0);
        }
        MoveSnake();
    }

    
    void MoveSnake()
    {
        snakePos.x += dir.x*0.1f;
        snakePos.y += dir.y*0.1f;
        snakeObj.transform.position = snakePos;
        snakeObj.transform.position = new Vector2(Mathf.Clamp(snakeObj.transform.position.x, camWidth.x, camWidth.y), Mathf.Clamp(snakeObj.transform.position.y, camHeight.x, camHeight.y));
        //snakeObj.transform.Translate(new Vector3(scl, 0, 0));

    }
}
