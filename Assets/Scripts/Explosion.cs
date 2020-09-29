using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//*
// Explosion.cs
//*
// Class behaviour
//*
// @category   Space Shooter Pro
// @tutorial   GameDevHQ
// @author     Dave González
// @copyright  2020 Dave González
// @version    CVS: 1.0
// @link       website
//*
public class Explosion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3f);
    }
}
