using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkPlank : MonoBehaviour
{
    [SerializeField] float plankLength;
    /*[HideInInspector]*/ public float currentPlankLength;

    public void StartShrinking(float amountToShrink)
    {
        while (transform.position.x > (transform.position.x - amountToShrink))
        {
            Debug.Log("it is still greater than where it needs to be");
        }
    }
}
