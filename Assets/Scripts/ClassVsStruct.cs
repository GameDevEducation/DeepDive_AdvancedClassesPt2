using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoClass
{
    public int IntValue;

    public DemoClass()
    {
        IntValue = 42;
    }
}

public struct DemoStruct
{
    public int IntValue;

    public DemoStruct(int _initialValue)
    {
        IntValue = _initialValue;
    }
}

public class ClassVsStruct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DemoClass dc1 = new DemoClass();
        DemoClass dc2 = dc1; // refers back to the original
        dc2.IntValue = 500;
        //dc1.IntValue = 5;
        Debug.Log(dc1.IntValue);
        
        DemoStruct ds1 = new DemoStruct(42);
        DemoStruct ds2 = ds1; // creates a copy
        ds2.IntValue = 500;
        //ds1.IntValue = 5;
        Debug.Log(ds1.IntValue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
