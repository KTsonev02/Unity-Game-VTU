using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        BallController player = other.gameObject.GetComponent<BallController>();
        other.transform.position = player.RespawnPoint.position;
    }
}
