using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PiggyActions : MonoBehaviour {

    // Movement Variables
    [SerializeField]
    private float movementSpeed;


    public void Move(float _val)
    {
        transform.position += movementSpeed * Vector3.right * _val * Time.deltaTime;
    }

    public void Jump()
    {

    }

}
