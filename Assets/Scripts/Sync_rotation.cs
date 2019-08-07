using UnityEngine;
using System.Collections;

public class Sync_rotation : MonoBehaviour
{
    public Transform theParent;
    public Transform theChild;


    void Update()
    {
        Quaternion NewRot = theChild.rotation;
        theChild.rotation = Quaternion.identity;
        theParent.rotation = NewRot;
    }
}