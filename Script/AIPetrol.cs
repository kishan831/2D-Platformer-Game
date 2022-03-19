using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPetrol : MonoBehaviour
{
    public float speed, distance;

    private bool movingRight = true;

    public Transform grounddetect;

    void Update() {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundinfo  = Physics2D.Raycast(grounddetect.position,Vector2.down,distance);
        if(groundinfo.collider == false ) {
            if(movingRight) {
                transform.eulerAngles = new Vector3(0,-180,0);
                movingRight = false;
            }

            else {
                transform.eulerAngles = new Vector3(0,0,0);
                movingRight = true;
            }
        }

    }
}
