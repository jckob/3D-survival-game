using UnityEngine;


[ExecuteAlways]
public class LightingManager : MonoBehaviour
{
    //references
    [SerializeField] private Light DirectionalLight;
    [SerializeField] private LightingPresent Present; //public
    //variables
    [SerializeField, Range(0, 240)] public float TimeofDay;


    public void Update()
    {
        if (Present == null)
        {
            return;
        }
        if (Application.isPlaying)
        {
            TimeofDay += Time.deltaTime;
            TimeofDay %= 240;
            UpdaeLighting(TimeofDay / 240f);
        }
        else
        {
            UpdaeLighting(TimeofDay / 240f);
        }
    }
    public void UpdaeLighting(float timePercent)
    {
        RenderSettings.ambientLight = Present.AmbientColor.Evaluate(timePercent);
        RenderSettings.fogColor = Present.Fogcolor.Evaluate(timePercent);

        if (DirectionalLight != null)
        {
            DirectionalLight.color = Present.DirectionalColor.Evaluate(timePercent);
            DirectionalLight.transform.localRotation = Quaternion.Euler(new Vector3((timePercent * 360f) - 90f, 170, 0));
        }
    
    }

    //Try to find a directional light to use if we haven't set one
    public void OnValidate()
    {
        if (DirectionalLight != null)
        {
            return;
        }

        //Search for lighting tab sun
        if (RenderSettings.sun != null)
        {
            DirectionalLight = RenderSettings.sun;
        }
        //Search scene for light that fits criteria (directional)
        else
        {
            Light[] lights = GameObject.FindObjectsOfType<Light>(); 
            foreach (Light light in lights)
            {
                if (light.type == LightType.Directional)
                {
                    DirectionalLight = light;
                    return;
                }
            }

        }


    }
}