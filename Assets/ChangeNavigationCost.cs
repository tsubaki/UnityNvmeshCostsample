using UnityEngine;
using System.Collections;

public class ChangeNavigationCost : MonoBehaviour {

	int selection;

	void SetNavmeshRoot (int layerNo)
	{
		for(int i=0; i<3; i++)
		{
			NavMesh.SetLayerCost(i + 3, layerNo == i ? 1 : 100);
		}
	}

	void Start()
	{
		SetNavmeshRoot(1);
	}

	void OnGUI()
	{
		for( int i=0; i<3; i++)
		{
			if( GUILayout.Button(string.Format("root{0} ({1:000})", i, NavMesh.GetLayerCost( i + 3))))
				SetNavmeshRoot(i);
		}

	}
}
