using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IConnectPoint 
{
    Vector3 position {
        get;
    }
    Quaternion rotation {
        get;
    }

}
