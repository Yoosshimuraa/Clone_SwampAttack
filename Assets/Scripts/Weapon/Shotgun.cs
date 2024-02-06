using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    [SerializeField] private int pelletsCount = 5; 

    public override void Shoot(Transform shootPoint)
    {
        for (int i = 0; i < pelletsCount; i++)
        {
            
            float spreadAngle = Random.Range(-10f, 10f);
            Quaternion spreadRotation = Quaternion.Euler(0, 0, spreadAngle);

            
            Instantiate(Bullet, shootPoint.position, shootPoint.rotation * spreadRotation);
        }
    }
}
