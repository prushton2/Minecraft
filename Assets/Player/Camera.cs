using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Camera : MonoBehaviour {
    public Transform player;
    float ChgInY = 0;
    bool ViewBobbingDown = true;
    public double viewHeight = 1.5;
    private GameObject mgr;
    void Start () {
      mgr = GameObject.Find("BlockManager");
    }
    void Update() {
      if(viewHeight >= 1.5) {
        ViewBobbingDown = false;
      }
      if(viewHeight <= 1.25) {
        ViewBobbingDown = true;
      }

      if(Input.GetMouseButtonDown(1)) {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 100)) {
          Vector3 objpos = new Vector3(hit.transform.position.x, hit.transform.position.y, hit.transform.position.z);
          Vector3 pos = objpos + hit.normal;
          mgr.GetComponent<instanceManager>().placeBlock(pos, new Vector3(0,0,0), hit);
        }
      }

      if(Input.GetMouseButtonDown(0)) {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5, 9)) {
          mgr.GetComponent<instanceManager>().breakBlock(hit);
        }
      }

      if(Input.GetKeyDown("e")) {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5, 9)) {
          mgr.GetComponent<instanceManager>().interactBlock(hit);
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

