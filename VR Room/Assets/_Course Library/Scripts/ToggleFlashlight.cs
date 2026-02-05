using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFlashlight : MonoBehaviour
{
    private Light _light;

    // Start is called before the first frame update
    void Start()
    {
        _light = GetComponent<Light>();
    }

   public void LightOn()
    {
        _light.enabled = true;
    }

    public void LightOff()
    {
        _light.enabled = false;
    }
}
