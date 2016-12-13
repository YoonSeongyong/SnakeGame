using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SnakeScript : MonoBehaviour {
	public ManagerScript mgr;
	public GameObject tailPrefab;
	public GameObject gameOverTxt;
	Vector2 dir = Vector2.right;
	Vector2 camWidth = new Vector2(-11.5f, 11.5f);//x is min, y is max
	Vector2 camHeight = new Vector2(-5.5f, 5.5f);
	bool ate = false;
	List<Transform> tail = new List<Transform>();
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Move", 0.3f, 0.05f);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.UpArrow))
			dir = new Vector2(0, 1);
		else if (Input.GetKeyDown(KeyCode.DownArrow))
			dir = new Vector2(0, -1);
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
			dir = new Vector2(-1, 0);
		else if (Input.GetKeyDown(KeyCode.RightArrow))
			dir = new Vector2(1, 0);
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.name.StartsWith ("foodPrefab")) {
			ate = true;

			Destroy (col.gameObject);
		} else {
			Time.timeScale = 0f;
			CancelInvoke ();
			gameOverTxt.SetActive (true);
		}
	}
	void Eat()
	{
		
	}
	void Move()
	{
		Vector2 curPos = transform.position;
		transform.Translate (dir);
//		transform.position = new Vector2(Mathf.Clamp(transform.position.x, camWidth.x, camWidth.y), Mathf.Clamp(transform.position.y, camHeight.x, camHeight.y));
		if(ate){
			GameObject _tail = (GameObject)Instantiate (tailPrefab,curPos,Quaternion.identity);
			tail.Insert (0,_tail.transform);
			ate = false;
		}else if(tail.Count > 0){
			tail.Last ().position = curPos;

			tail.Insert (0, tail.Last());
			tail.RemoveAt (tail.Count-1);
		}
	}
}
