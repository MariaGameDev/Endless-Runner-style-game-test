using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBG : MonoBehaviour
{
    [SerializeField] float bgSpeed;
    [SerializeField] Renderer bg_renderer;

    void Start()
    {
        
    }

    
    void Update()
    {
        bg_renderer.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime, 0);
    }
}
