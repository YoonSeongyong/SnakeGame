using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ManagerScript : MonoBehaviour
{
    public GameObject foodPrefab;

	Vector2 camWidth = new Vector2(-11.5f, 11.5f);//x is min, y is max
	Vector2 camHeight = new Vector2(-5.5f, 5.5f);
	//	private Camera cam = Camera.main;
    GameObject food;
    Vector2 dir = new Vector2(1, 0);
    Vector2 snakePos, prevPos;
		
    // Use this for initialization
//    void Awake()
//    {
//        QualitySettings.vSyncCount = 0;
//        Application.targetFrameRate = 15;
//    }

    void Start()
    {
//        snakeObj.transform.position = new Vector2(0.5f, 0.5f);
//        snakePos = snakeObj.transform.position;
		InvokeRepeating("Spawn",3.0f,3.0f);
    }		

    void Spawn()
    {
		int x = Random.Range (-11,11);
		int y = Random.Range (-5,5);
		Instantiate (foodPrefab,new Vector2((float)x+0.5f,(float)y+0.5f),Quaternion.identity);
    }

    public void Eat()
	{

    }

    int RandPos(int min, int max)
    {
        return Random.Range(min, max);
    }
}
