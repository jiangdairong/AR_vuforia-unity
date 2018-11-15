using UnityEngine;
using System.Collections;

public class shot : MonoBehaviour {
	public GameObject bullet;
	private float timer;
	public GameObject target;
	// Use this for initialization
	void Start () {
		timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= 2.0f) {
			//if()
			GameObject bullets = Instantiate(bullet,transform.position,Quaternion.identity) as GameObject;
			bullets.AddComponent<bullets> ();
			timer = 0;
		}
		Vector3 rot = new Vector3 ((target.transform.position - transform.position).x,(target.transform.position - transform.position).y,180);
		transform.rotation = Quaternion.LookRotation(rot);
	}
}
