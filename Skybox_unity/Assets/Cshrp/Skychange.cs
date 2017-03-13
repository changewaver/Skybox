using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skychange : MonoBehaviour {
    //public Material[] materials;
    public float changeInterval = 0.33F;
    //public Renderer rend;
    public Material[] materials;

    void Start()

    {
        int i = 0;
        //rend = GetComponent<Renderer>();
        //rend.enabled = true;
        
    }

    void Update()
    {
        
        if (materials.Length == 0)
            return;

        // we want this material index now
        int index = Mathf.FloorToInt(Time.time / changeInterval);

        // take a modulo with materials count so that animation repeats
        index = index % materials.Length;

        // assign it to the renderer
        //rend.sharedMaterial = materials[index];

        
        RenderSettings.skybox = materials[index];
    }
}
