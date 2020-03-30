using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : Block
{
    public Stone() {}

    public override bool render() {
        Instantiate(GameObject.Find("Stone"), base.position, Quaternion.Euler(0,0,0));
        base.isRendered = true;
        return true;
    }
}
