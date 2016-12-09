using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ManagerScript : MonoBehaviour
{
    public GameObject snakeObj;
//	private Camera cam = Camera.main;
	List<GameObject> snakeBody = new List<GameObject>();
	GameObject feed;
    float scl, xspeed, yspeed;
    Vector2 camWidth = new Vector2(-11.5f,11.5f);//x is min, y is max
    Vector2 camHeight = new Vector2(-5.5f,5.5f);
    Vector2 dir = new Vector2(1,0);
    Vector2 snakePos;
    // Use this for initialization
	void Awake()
	{
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate = 15;
	}

    void Start()
    {
        //scl = 0.125f;
        //Debug.Log(Camera.main.pixelWidth);
        //xspeed = Camera.main.pixelWidth / scl;
        //yspeed = Camera.main.pixelHeight / scl;
//		snakeObj.transform.position = cam.WorldToScreenPoint(snakeObj.transform.position);
		snakeObj.transform.position = new Vector2(0.5f,0.5f);
		snakeBody.add = snakeObj;
        snakePos = snakeObj.transform.position;
		CreateSnake ();
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown (KeyCode.UpArrow))
			dir = new Vector2 (0, 1);
		else if (Input.GetKeyDown (KeyCode.DownArrow))
			dir = new Vector2 (0, -1);
		else if (Input.GetKeyDown (KeyCode.LeftArrow))
			dir = new Vector2 (-1, 0);
		else if (Input.GetKeyDown (KeyCode.RightArrow))
			dir = new Vector2 (1, 0);
        MoveSnake();
    }

    
    void MoveSnake()
    {
<<<<<<< HEAD
        snakePos.x += dir.x*0.1f;
        snakePos.y += dir.y*0.1f;
        snakePos = new Vector2(Mathf.Clamp(snakePos.x, camWidth.x, camWidth.y), Mathf.Clamp(snakePos.y, camHeight.x, camHeight.y));
        snakeObj.transform.position = snakePos;
=======
		snakePos.x += dir.x;
		snakePos.y += dir.y;
//        snakePos.x += dir.x*0.1f;
//        snakePos.y += dir.y*0.1f;
		snakePos = new Vector2(Mathf.Clamp(snakePos.x, camWidth.x, camWidth.y), Mathf.Clamp(snakePos.y, camHeight.x, camHeight.y));
		snakeObj.transform.position = snakePos;
>>>>>>> refs/remotes/origin/ReDesign
        //snakeObj.transform.Translate(new Vector3(scl, 0, 0));

    }

	void CreateSnake()
	{
		Vector2 snake_b = new Vector2((float)RandPos(-11, 11)+0.5f,(float)RandPos(-5,5)+0.5f);
		feed = Instantiate (snakeObj,snake_b,Quaternion.identity);
	}

	void Eat()
	{
		snakeBody
	}

	int RandPos(int min, int max)
	{
		return Random.Range (min,max);
	}
}
