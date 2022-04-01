using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rBody;
    public float speed;

    private void Start() {
        rBody = GetComponent<Rigidbody>();

    }

    private void FixedUpdate() {
        rBody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rBody.velocity.y);
    }
}
