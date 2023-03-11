using System.Collections;
using System.Collections.Generic;
using Unity.FPS.AI;
using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.UI;

public class RisingLavaAnimation : MonoBehaviour
{
    public float moveSpeed = 0.2f;
    int levelTrigger = 2;
    public int totalDistanceToTravel = 50;
    float xValue = 0;
    float zValue = 0;


    float distanceTravelled;
    Vector3 lastPosition;
    EnemyManager m_EnemyManager;
    // Start is called before the first frame update
    void Start()
    {
        m_EnemyManager = FindObjectOfType<EnemyManager>();
    }

    // Update is called once per frame
    void Update()
    {
        lastPosition = transform.position;
        if (m_EnemyManager.levelCount >= levelTrigger)
        {
            float yValue = Time.deltaTime * moveSpeed;
            transform.Translate(xValue, yValue, zValue);
        }

        distanceTravelled += Vector3.Distance (transform.position, lastPosition);
        
        if (distanceTravelled >= totalDistanceToTravel)
        {
            Destroy(this);
        }

    }
}
