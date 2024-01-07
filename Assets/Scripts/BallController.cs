using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Transform respawnPont;
    private float speed = 10f;
    private Rigidbody rb;

    public Transform RespawnPoint
    {
        get => respawnPont;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new(horizontal, 0.0f, vertical);
        rb.AddForce(direction * speed);
    }
}