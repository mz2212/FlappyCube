using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    public float speed = 4f;

    void FixedUpdate() {
        transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
    }

    void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
    }
}
