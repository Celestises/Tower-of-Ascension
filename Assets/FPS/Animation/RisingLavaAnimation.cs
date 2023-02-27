using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingLavaAnimation : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // how do we trigger this with the level being completed?
        float xValue = 0;
        float yValue = Time.deltaTime * moveSpeed;
        float zValue = 0;

        transform.Translate(xValue, yValue, zValue);
        
        // how to make it stop?
    }
}
