using UnityEngine;
using System.Collections;

public class spanwn : MonoBehaviour {


	public GameObject [] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	public float timepsed=0f;
	// Use this for initialization
	void Start () {
		Spawn ();
	}
	void Spawn()
	{
		Instantiate(obj[Random.Range(0,obj.GetLength(0))],transform.position, Quaternion.identity);
		print (Time.deltaTime);
		timepsed = timepsed + Time.deltaTime;
		print ("all time");
		print (timepsed);
		Invoke ("Spawn", Random.Range(1f,2f *(1f+timepsed)));
	}
}
