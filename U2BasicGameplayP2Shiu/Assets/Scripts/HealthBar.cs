using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class HealthBar : MonoBehaviour




{
    public RectTransform healthRectangle;

    
    // Start is called before the first frame update
    void Start()
    {
        healthRectangle.sizeDelta = new Vector2(1100, healthRectangle.rect.height);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
   
}
