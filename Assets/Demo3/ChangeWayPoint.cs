using UnityEngine;
using System.Collections;

public class ChangeWayPoint : MonoBehaviour {

	public Transform[] positions;
	public Transform target;

	void OnGUI()
	{
		foreach( var pos in positions)
		{
			if( GUILayout.Button(pos.name))
			{
				target.position = pos.position;
			}
		}
	}
}
