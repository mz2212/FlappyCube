using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourRandomizer : MonoBehaviour {
    Renderer rend;

    void Start() {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.HSVToRGB(Random.value, 1, 1);
    }
}
