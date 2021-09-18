using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePosition : MonoBehaviour
{
	public bool moveNow;

	[SerializeField] private float speed;
	
	[SerializeField] private Vector3 addToPosition;

	private bool startMoving;
	private Vector3 startPosition;
	private Vector3 targetPosition;

	private void Start()
	{
		startPosition = transform.position;
	}

	private void Update()
	{
		if (moveNow)
		{
			MoveObject();
		}

		if (startMoving)
		{
			transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
			if (Vector3.Distance(transform.position, targetPosition) < 0.001f)
			{
				transform.position = targetPosition;
				startMoving = false;
			}
		}
	}

	private void MoveObject()
	{
		startMoving = true;
		targetPosition = startPosition + addToPosition;
	}
}
