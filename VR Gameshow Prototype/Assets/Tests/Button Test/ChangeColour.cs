using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{

	[SerializeField] Color color;

	private new Renderer renderer;

	private void Start()
	{
		renderer = gameObject.GetComponent<Renderer>();
	}

	private void ChangeWallColour()
	{
		renderer.material.color = color;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Ball")
		{
			ChangeWallColour();
		}
	}
}
