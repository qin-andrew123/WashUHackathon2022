using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Gun", menuName = "Create/New Gun")]
public class Gun_Base : ScriptableObject
{
    public int numBullets;
    public float bulletSpeed;
    public float angleOfFire;
    public int damageVal;
    public float timeBtwnShots;
}
