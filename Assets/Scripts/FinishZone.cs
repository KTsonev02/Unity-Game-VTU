using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishZone : MonoBehaviour
{
    [SerializeField] private Vector3 launchForce;


    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        //wining code:
        other.GetComponent<Rigidbody>().AddForce(launchForce);
        print("YOU WIN!!!");
    }
}
