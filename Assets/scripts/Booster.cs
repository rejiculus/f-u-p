using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Booster : MonoBehaviour
{
    [SerializeField]
    private int _boost = 300;

    [SerializeField]
    private Rigidbody _gameObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {           
            other.GetComponent<Rigidbody>().AddForce(transform.up * _boost);
        }
    }
}
