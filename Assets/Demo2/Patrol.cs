using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour {
	
	public Transform[] wayPoints;
	
	public int currentRoot;
	
	void Update ()
	{
		Vector3 pos = wayPoints[currentRoot].position;
		
		if(Vector3.Distance(transform.position, pos) < 0.5f)
		{
			currentRoot = (currentRoot < wayPoints.Length - 1) ? currentRoot + 1 : 0;
		}
		
		GetComponent<NavMeshAgent>().SetDestination(pos);
	}
}