using System.Collections;
using System.Collections.Generic;
using Unity.FPS.AI;
using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.UI;

public class FloorPiece1Lvl0 : MonoBehaviour
{
    float moveSpeed = .5f;
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
        if (m_EnemyManager.levelCount >= 1)
        {
            float xValue = Time.deltaTime * moveSpeed;
            float yValue = 0;
            float zValue = Time.deltaTime * moveSpeed;

            transform.Translate(xValue, yValue, zValue);
        }
        
        distanceTravelled += Vector3.Distance (transform.position, lastPosition);
        
        if (distanceTravelled >= 40)
        {
            Destroy(this);
        }

    }
}
