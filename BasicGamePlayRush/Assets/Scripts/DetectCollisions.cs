using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == GameObject.FindWithTag("Player"))
        {
            PlayerStats.lives--;
            Debug.Log("lives=" + PlayerStats.lives);
            if (PlayerStats.lives < 1)
            {
                Debug.Log("Game Over!");
                Destroy(GameObject.FindWithTag("Player"));
                CancelInvoke();
            }
        }

        Destroy(gameObject);
        Destroy(GameObject.FindWithTag("Food"));

        PlayerStats.score++;
        Debug.Log("Score=" + PlayerStats.score);

        if(other.CompareTag("Player"))
        {
            Debug.Log("Game Over!!!!");
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }

}
