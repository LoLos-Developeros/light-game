using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotate : MonoBehaviour
{
    public GameObject player;
    public float cameraHeight = 20f;
    public float cameraWidht = 20f;

    void Update()
    {
        Vector3 pos = player.transform.position;
        pos.z += cameraHeight;
        pos.y += cameraWidht;
        transform.position = pos;
    }
}
