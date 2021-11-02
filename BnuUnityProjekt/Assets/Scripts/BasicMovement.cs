using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float speed = 10f;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));

        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + movement * Time.deltaTime * speed;
    }
}
