using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Transform goal;

	NavMeshAgent agent;

	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	void Update () 
	{
		agent.SetDestination(goal.position);
	}
}
