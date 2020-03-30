using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanceManager : MonoBehaviour
{
    // Start is called before the first frame update
    List<Block> blocks = new List<Block>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Block block in blocks) {
            //try{
                if(!block.isRendered) {
                    block.render();
                    Debug.Log("Rendered Block");
                }
            //}catch{}
        }
        if(Input.GetKeyDown(PlayerPrefs.GetString("Interact"))) {
            blocks.Add(new Stone());
            Debug.Log(blocks.Count);
        }
    }
}
