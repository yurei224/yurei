using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bull : MonoBehaviour
{
    public float speed;
    public float distance;
    public int damage;
    public LayerMask layerMask;
    

    void Update()
    {
        RaycastHit2D other = Physics2D.Raycast(transform.position, transform.up, distance, layerMask);
        if (other.collider.CompareTag("vrag"))
        {
            other.collider.GetComponent<vrag>().TakeDamage(damage);
            Destroy(gameObject);
        }

        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
