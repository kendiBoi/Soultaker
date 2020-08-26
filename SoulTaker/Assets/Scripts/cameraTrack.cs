using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class cameraTrack : MonoBehaviour
{
    public Transform target;
    Vector3 Velocity = Vector3.zero;
    public float smoothTime;

    public bool YMaxEnabled;
    public float YMaxValue;

    public bool YMinEnabled;
    public float YMinValue;

    public bool XMaxEnabled;
    public float XMaxValue;

    public bool XMinEnabled;
    public float XMinValue;

    // Start is called before the first frame update
    
    void LateUpdate()
    {

       Vector3 targetPos = target.position;




        if (YMinEnabled && YMaxEnabled)
        {
            targetPos.y = Mathf.Clamp(target.position.y, YMinValue, YMaxValue);
        }
        else if (YMinEnabled)
        {
            targetPos.y = Mathf.Clamp(target.position.y, YMinValue, target.position.y);
        }
        else if (YMaxEnabled)
        {
            targetPos.y = Mathf.Clamp(target.position.y, target.position.y, YMaxValue);
        }
        
        if (XMinEnabled && XMaxEnabled)
        {
            targetPos.x = Mathf.Clamp(target.position.x, XMinValue, XMaxValue);
        }
        else if (YMinEnabled)
        {
            targetPos.x = Mathf.Clamp(target.position.x, XMinValue, target.position.x);
        }
        else if (YMaxEnabled)
        {
            targetPos.x = Mathf.Clamp(target.position.x, target.position.x, XMaxValue);
        }

        targetPos.z = -100f;
        transform.position = Vector3.SmoothDamp(target.position, targetPos, ref Velocity, smoothTime);
        

    }
    
}
