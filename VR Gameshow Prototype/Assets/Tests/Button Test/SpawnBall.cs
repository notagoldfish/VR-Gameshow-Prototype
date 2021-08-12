using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{

	[SerializeField] GameObject ballPrefab;

    public void CreateBall()
	{
		Instantiate(ballPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
	}
}
