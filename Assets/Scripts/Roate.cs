using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roate : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    private void Update()
    {
        transform.Rotate(0, 0, 180 * speed * Time.deltaTime);
    }
}
