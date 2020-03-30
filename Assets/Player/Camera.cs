using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public Transform player;
    float ChgInY = 0;
    bool ViewBobbingDown = true;
    public double viewHeight = 1.5;
    void Start () {

    }
    void Update() {
        if(viewHeight >= 1.5) {
          ViewBobbingDown = false;
        }
        if(viewHeight <= 1.25) {
          ViewBobbingDown = true;
        }

        if (Input.GetKey("e")) {
          RaycastHit hit; //Creates a raycast instance saved in hit
          //                  Start pos               Direction                 Forward         Output    Range
          //                        |                       |                        |          variable   |
          if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15)) { //Return true if it hit something
          }
        }
        ChgInY += Input.GetAxisRaw("Mouse Y");
        if (ChgInY > 90f) {
          ChgInY = 90f;
        } else if(ChgInY < -90f) {
          ChgInY = -90f;
        }
        var euler = player.transform.rotation.eulerAngles;
        transform.rotation = Quaternion.Euler(-ChgInY, euler.y, 0);        
    }
}

