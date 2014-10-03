using UnityEngine;
using System.Collections;

public class ClickAndMovePosition : MonoBehaviour {

	public Transform target;

	void Update()
	{
		if( Input.GetMouseButtonDown(0)){
			RaycastHit hit;
			if( Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
			{
				target.position = hit.point;
			}
		}
	}
}
