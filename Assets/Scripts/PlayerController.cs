using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    public float speed = 3f;
    public float vertForce = 10f;
    Rigidbody rb;
    bool doJump;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            doJump = true;
        }
    }

    void FixedUpdate() {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if(doJump) {
            doJump = false;
            rb.velocity = Vector3.zero;
            rb.AddForce(new Vector3(0, vertForce, 0), ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit(0);
        }

        if(screenPos.y > Screen.height || screenPos.y < 0 || screenPos.x > Screen.width || screenPos.x < 0) {
            Die();
        }
    }

    private void Die() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
