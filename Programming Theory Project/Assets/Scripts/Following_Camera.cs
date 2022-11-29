using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Following_Camera : MonoBehaviour
{
    public GameObject player;
public Vector3 offset = new Vector3(0f, 50f, 0f);
// private Vector3 offset2 = new Vector3(1.75f, 2.4f, -14f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // camera offset following the player
        transform.position = player.transform.position + offset;
       // transform.position = player.transform.position + offset2;
    }
}
