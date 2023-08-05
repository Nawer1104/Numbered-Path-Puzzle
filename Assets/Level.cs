using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public List<Line> lines;


    public bool CheckActiveAll() {
        foreach (Line line in lines)
        {
            if (!line.transform.GetChild(0).gameObject.activeSelf) {
                return false;
            }
        }

        return true;
    }
}
