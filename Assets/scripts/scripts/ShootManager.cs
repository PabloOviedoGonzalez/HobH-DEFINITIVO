using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootManager : MonoBehaviour
{
    public static bool Fire
    {
        get { return Input.GetKey(KeyCode.Space); }
    }
}
