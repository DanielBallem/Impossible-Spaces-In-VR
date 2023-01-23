using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertObjectToLayer : MonoBehaviour
{
    public int layerIndex = 6;
    public bool changeOnExit = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != layerIndex)
            other.gameObject.layer = layerIndex;
    }

    private void OnTriggerExit(Collider other)
    {
        if (changeOnExit)
            other.gameObject.layer = layerIndex;
    }
}
