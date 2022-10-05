using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAnim : MonoBehaviour
{
    public Animator anim;
    public bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isOpen = !isOpen;
            anim.SetBool("Open", isOpen);
        }
    }
}
