using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    [SerializeField]
    private Rigidbody2D enbody;

    // Start is called before the first frame update
    void Awake()
    {
        enbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        enbody.velocity = new Vector2(speed, enbody.velocity.y);
    }
}
