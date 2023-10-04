using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        GameManager.Instance.Attach(this);
    }

    public void Execute(ISubject subject)
    {
        if (subject is GameManager)
        {
            speed = ((GameManager)subject).Progression;
        }
    }


    void Update()
    {
        rb.velocity = new Vector3(0, rb.velocity.y, speed);
    }
}
