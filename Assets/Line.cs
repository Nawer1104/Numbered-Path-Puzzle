using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
            transform.GetChild(0).gameObject.SetActive(false);
    }

    private void OnMouseEnter()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
