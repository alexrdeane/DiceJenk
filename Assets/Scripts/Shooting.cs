using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject dice;
    private GameObject clone;
    private Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponentInChildren<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
           Destroy(clone);
            SpawnDice();
        }
    }

    void SpawnDice()
    {
        Quaternion randomRot = Quaternion.Euler(Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f));
        clone = Instantiate(dice, transform.position, randomRot);
        rigid = clone.GetComponent<Rigidbody>();
        rigid.AddForce(transform.forward * 30f, ForceMode.Impulse);
    }
}