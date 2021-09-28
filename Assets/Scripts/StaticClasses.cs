using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DemoStaticClass
{
    public static int MaxHealth = 500;

    public static void TestFunction()
    {

    }
}

public class DemoStaticFunction
{
    private DemoStaticFunction()
    {

    }

    public static DemoStaticFunction Create()
    {
        return new DemoStaticFunction();
    }

    public static void TestFunction()
    {

    }
}

public class StaticClasses : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DemoStaticClass.TestFunction();
        Debug.Log(DemoStaticClass.MaxHealth);

        var dsf1 = DemoStaticFunction.Create();
        //var dsf2 = new DemoStaticFunction(); // This is not permitted because the constructor is privat
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
