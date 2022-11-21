using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    public int damageCount = 10;
    private void OnCollisionEnter(Collision collision)
    {
        HP.Damage(damageCount);
    }

}
