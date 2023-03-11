using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.FPS.Game;

public class lavakill : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform kill;

    public void OnTriggerEnter(Collider other){
        if (other.transform.gameObject.tag=="Player")
        {
            Debug.Log("message");
            other.transform.GetComponent<Health>().Kill();
        }
        
    }
}
