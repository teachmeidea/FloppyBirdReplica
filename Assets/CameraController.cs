using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform bird;

    void LateUpdate()
    {
        if (bird != null)
        {
            if (bird.position.x > transform.position.x)
            {
                Vector3 cPos = transform.position;
                cPos.x = bird.position.x;
                transform.position = cPos;
            }
        }
    }
}
