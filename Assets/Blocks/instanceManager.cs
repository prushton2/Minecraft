using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanceManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Block> blocks = new List<Block>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void placeBlock(Vector3 pos, Vector3 rot) {
        Instantiate(GameObject.Find("Stone"), pos, Quaternion.Euler(rot.x, rot.y, rot.z));
    }
    public void breakBlock(RaycastHit hit) {
        Destroy(hit.transform.gameObject);
    }
}
