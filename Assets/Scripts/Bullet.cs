using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;

    private void Update()
    {

        float currentRotation = transform.eulerAngles.z;


        float radianAngle = currentRotation * Mathf.Deg2Rad;


        Vector2 moveDirection = new Vector2(-Mathf.Cos(radianAngle), -Mathf.Sin(radianAngle));


        transform.Translate(moveDirection * _speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamage(_damage);

            Destroy(gameObject);
        }
    }
}
