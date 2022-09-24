using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIDropLeft : MonoBehaviour
{
    public Image starterCircle;
    public Image endCircle;
    public Image bodySquare;
    public float speed = 1;
    public float length;

    public bool IsOpening = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsOpening == true)
        {
            Debug.Log("endCircle.rectTransform.localPosition.x");
            if (endCircle.rectTransform.localPosition.x >= (starterCircle.rectTransform.localPosition.x + length))
            {
                IsOpening = false;
            }

            endCircle.rectTransform.localPosition += new Vector3(1, 0, 0) * speed * Time.deltaTime;

        }
    }
}
