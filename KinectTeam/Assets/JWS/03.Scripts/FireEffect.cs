using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEffect : MonoBehaviour
{
    public Transform firePos;
    public GameObject fireFac;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Contains("Flower"))
        {
            GameObject udoTan = Instantiate(fireFac);
            udoTan.transform.position = firePos.position;
            Destroy(other.gameObject);
        }
    }
}
