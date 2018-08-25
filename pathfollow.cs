using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathfollow : MonoBehaviour {
	public Transform[] path;
	public float speed = 200.0f;
	public float reach = 1.0f ;
	public int currentPoint = 0;

	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance (path [currentPoint].position, transform.position);
		transform.position = Vector3.MoveTowards (transform.position,path[currentPoint].position,speed*Time.deltaTime);
		if (dist <= reach)
			currentPoint++;
		if (currentPoint >= path.Length)
			currentPoint = 0;
	}

	void OnDrawGizmos(){
		
		if (path.Length > 0) {
			for(int i=0;i<path.Length;i++){
				if (path [i]!=null)
					Gizmos.DrawSphere (path[i].position,reach);
			}
		}
	}
}
