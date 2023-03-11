using System.Collections;
using System.Collections.Generic;
using Unity.FPS.AI;
using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawn : MonoBehaviour
{

    public GameObject newEnemy;
    EnemyManager m_EnemyManager;

    bool hasBeenSpawned = false;

    // Start is called before the first frame update
    void Start()
    {
        m_EnemyManager = FindObjectOfType<EnemyManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (!hasBeenSpawned && m_EnemyManager.levelCount == 2)
        {
            hasBeenSpawned = true;
            Instantiate(newEnemy, transform.position, Quaternion.identity);
            //m_EnemyManager.RegisterEnemy(newEnemy);
        }
    }
}
