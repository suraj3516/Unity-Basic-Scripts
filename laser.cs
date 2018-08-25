using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour {
	public LineRenderer l;
	public Transform origin;
	public Transform target;
	// Use this for initialization
	void Start () {
		l = GetComponent<LineRenderer> ();
		l.startWidth= 5f;
		l.endWidth = 5f;
	}

	// Update is called once per frame
	void Update () {
		l.SetPosition (0, origin.position);
		l.SetPosition (1,target.position);

	}
}
