using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    private Transform player;
    private string pl_tag = "Player";

    private Vector3 temppos;

    [SerializeField]
    private float minX, maxX;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag(pl_tag).transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        if (player == null)
            return;

        temppos = transform.position;
        temppos.x = player.position.x;

        if (temppos.x < minX)
            temppos.x = minX;

        if (temppos.x > maxX)
            temppos.x = maxX;

        transform.position = temppos;
    }
}
