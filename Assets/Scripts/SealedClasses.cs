using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class DemoSealedClass
{

}

// this is not permitted as the class is sealed
// public class DemoInheritedClass : DemoSealedClass
// {

// }

public class DemoBaseClass
{
    public virtual void DemoFunction()
    {

    }
}

public class DemoChildClass : DemoBaseClass
{
    public sealed override void DemoFunction()
    {
        base.DemoFunction();
    }
}

public class DemoGrandChildClass : DemoChildClass
{
    // this is not permitted as the function is sealed
    // public override void DemoFunction()
    // {
    //     base.DemoFunction();
    // }
}

public class SealedClasses : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
