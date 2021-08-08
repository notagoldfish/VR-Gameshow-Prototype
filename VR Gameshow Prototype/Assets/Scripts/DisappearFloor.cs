using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearFloor : MonoBehaviour
{
    public float spd;

    public float startDisappearAfter;

    public float deleteAfter;

    private bool disappear;

    private void Start()
    {
        Invoke("Disappear", startDisappearAfter);
    }

    private void Update()
    {
        if (disappear == true)
        {
            transform.Translate(Vector3.forward * spd * Time.deltaTime);
        }
    }

    private void Disappear()
    {
        disappear = true;

        Destroy(this.gameObject, deleteAfter);
    }
}
