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
    public void placeBlock(Vector3 pos, Vector3 rot, RaycastHit hit) {
        if(GameObject.Find("Player").GetComponent<Player>().occupiedBlock() != pos && hit.transform.gameObject.name != "Player") {
            // Debug.Log((pos, hit.transform.gameObject.name, hit.normal));
            Instantiate(GameObject.Find("Stone"), pos, Quaternion.Euler(rot.x, rot.y, rot.z));
        }
    }
    public void breakBlock(RaycastHit hit) {
        // Debug.Log(hit.transform.gameObject.tag);
        if(hit.transform.gameObject.tag == "Block") {
            Destroy(hit.transform.gameObject);
        }
    }

    public bool interactBlock(RaycastHit hit) {
        return hit.transform.gameObject.GetComponent<Block>().isInteractable;
    }
}
