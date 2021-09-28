using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCharacter
{
    protected Vector3 Location;

    public abstract void MoveTo(Vector3 newLocation, float speed);

    public void NavigateTo(Vector3 newLocation)
    {
        // common setup goes here

        NavigateTo_Internal(newLocation);

        // common cleanup goes here
    }

    protected abstract void NavigateTo_Internal(Vector3 newLocation);

    public void TeleportTo(Vector3 newLocation)
    {
        Debug.Log("Teleport to " + newLocation);
    }
}

public class PlayerCharacter : BaseCharacter
{
    public override void MoveTo(Vector3 newLocation, float speed)
    {
        Debug.Log("Move to " + newLocation + " at " + speed);
    }

    protected override void NavigateTo_Internal(Vector3 newLocation)
    {
        
    }
}

public class AbstractClasses : MonoBehaviour
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
