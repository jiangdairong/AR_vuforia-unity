using UnityEngine;
using System.Collections;

public class bullets : MonoBehaviour {
	//public Quaternion targetRotation;
	public GameObject target;
	// Use this for initialization
	void Start () {
		target = GameObject.Find ("yoshi");
	}
	
	// Update is called once per frame
	void Update () {
		
		if ((this.transform.position - target.transform.position).magnitude < 31.11f) {
			Destroy (this.gameObject);
		} else {
			this.transform.position = Vector3.MoveTowards (transform.position,target.transform.position,10.0f);
			//this.transform.rotation = quate;
			Vector3 rot = new Vector3((target.transform.position - transform.position).x,(target.transform.position - transform.position).y-90.0f,(target.transform.position - transform.position).z);
			Quaternion rotation = Quaternion.LookRotation(rot);
			this.transform.rotation = rotation;
		}
	}
}
