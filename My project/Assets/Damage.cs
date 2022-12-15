using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    public int collisionDamage;
    public string collisionTag;
    

    /*private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == collisionTag)
        {
            SceneManager.LoadScene(0);
            Health health = coll.gameObject.GetComponent<Health>();
            health.TakeHit(collisionDamage);
        }
    }*/
}
