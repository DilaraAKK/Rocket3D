using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    public GameObject bombPrefab;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RedRocket")
        {
            Instantiate(bombPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        
    }
}
