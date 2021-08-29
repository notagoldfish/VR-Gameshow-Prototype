using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkPlank : MonoBehaviour
{
    //[SerializeField] private float plankLength;
    //[HideInInspector] public float currentPlankLength;

	[SerializeField] private float speed;
	private bool shrinking;
	private float targetLocation;

	public void StartShrinking(float amountToShrink)
    {
		targetLocation = transform.position.x - amountToShrink; // Maybe if you added "- targetLocation" after amountToShrink it would also allow this to be acted on twice in the same shrinking time without screwing up the final location
		shrinking = true;
	}

	private void Update()
	{
		if (shrinking == true)
		{
			var vectorTarget = new Vector3(targetLocation, transform.position.y, transform.position.z);
			transform.position = Vector3.MoveTowards(transform.position, vectorTarget, Time.deltaTime * speed);
			if (transform.position.x == targetLocation)
			{
				shrinking = false;
			}
		}
	}
}
