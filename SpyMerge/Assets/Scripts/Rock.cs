using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    private bool isOnPlayer;
    private bool isGround = true;

    private void Update()
    {
        // Ensure the rock follows the player only when it's supposed to be on the player
        if (isOnPlayer)
        {
            var player = GameObject.Find("Player").transform;
            transform.position = new Vector3(player.position.x, player.position.y + 2.5f, player.position.z);
            transform.rotation = player.rotation;
        }

        CheckGroundStatus();
    }

    private void CheckGroundStatus()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1))
        {
            isGround = hit.transform.gameObject.CompareTag("Ground");
        }
        else
        {
            isGround = false;
        }
    }

    public void SetOnPlayer()
    {
        isOnPlayer = !isOnPlayer;
        var rb = transform.GetComponent<Rigidbody>();
        rb.useGravity = !isOnPlayer;
        rb.isKinematic = isOnPlayer; // Make Rigidbody not affect physics when on player
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && !isGround)
        {
            Debug.Log("Hit enemy");
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Target"))
        {
            Destroy(collision.gameObject);
        }
    }
}