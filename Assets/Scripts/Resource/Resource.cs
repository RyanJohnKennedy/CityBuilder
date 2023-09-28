using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum RESOURCE_TYPE
{
    Wood,
    Gold
}
public class Resource : MonoBehaviour
{
    public RESOURCE_TYPE resourceType;
    public int maxResourceAmount;
    public int currentResourceAmount;

    // Start is called before the first frame update
    void Start()
    {
        currentResourceAmount = maxResourceAmount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
