using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {
    public float genTime = 1.5f;
    public float firstTime = 0f;
    public GameObject obstacle;
    int score;

    void Start() {
        InvokeRepeating("DoGeneration", firstTime, genTime);
    }

    private void OnGUI() {
        GUI.color = Color.black;
        GUILayout.Label(" Score: " + score.ToString());
    }

    private void DoGeneration() {
        Instantiate(obstacle, new Vector3(20f, Random.Range(-3, 3), 0), Quaternion.identity);
        score++;
    }
}
