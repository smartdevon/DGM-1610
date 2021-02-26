using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsCollectionBehavior : MonoBehaviour
{
    public Weapon weaponObj;
    public WeaponCollection weaponCollectionObj;
    private void OnTriggerEnter2D(Collider2D other)
    {
        weaponCollectionObj.weaponList.Add(weaponObj);
        gameObject.SetActive(false);
    }
}
