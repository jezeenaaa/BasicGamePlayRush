using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectGameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Game Over!");
    }
}
