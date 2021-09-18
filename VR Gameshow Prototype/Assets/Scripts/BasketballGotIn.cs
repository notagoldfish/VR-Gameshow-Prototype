using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballGotIn : MonoBehaviour
{

	private bool inPointA;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Basketball_PointA")
		{
			inPointA = true;
		}
		if (inPointA)
		{
			if (other.gameObject.tag == "Basketball_PointB")
			{
				Debug.Log("Scored!");
			}
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Basketball_PointA")
		{
			inPointA = false;
		}
	}
}
