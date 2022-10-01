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

    public List<Image> icons = new List<Image>();
    public Vector3 initialPosition_0;
    public Vector3 finalPosition;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition_0 = icons[0].rectTransform.localPosition;
        finalPosition = starterCircle.rectTransform.localPosition + new Vector3(length, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(IsOpening == true)
        {
            if(endCircle.rectTransform.localPosition.x >= starterCircle.rectTransform.localPosition.x + length)
            {
                IsOpening = false;
            }

            //Debug.Log("X Start" + starterCircle.rectTransform.localPosition.x + "X end" + endCircle.rectTransform.localPosition.x);
            endCircle.rectTransform.localPosition += new Vector3(1, 0, 0) * speed * Time.deltaTime;

            //expand and move at the sametime
            bodySquare.rectTransform.localPosition += new Vector3(0.5f, 0, 0) * speed * Time.deltaTime;
            bodySquare.rectTransform.sizeDelta += new Vector2(1f * speed * Time.deltaTime, 0);



            icons[0].rectTransform.localPosition = Vector3.Lerp(initialPosition_0, finalPosition, 1 * speed * Time.deltaTime);

        }
    }
}
