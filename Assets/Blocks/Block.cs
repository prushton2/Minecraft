using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Block : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 position = new Vector3(0,-1,0);
    public bool isInteractable = false;
}
