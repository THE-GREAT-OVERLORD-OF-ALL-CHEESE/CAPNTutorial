using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cheese.GOAP;

public class SimpleMouseClick : MonoBehaviour
{
    public Camera cam;
    public float height = 15f;
    public GOAPDriver driver;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                DoStuff(hit.point + hit.normal * height);
            }
        }
    }

    private void DoStuff(Vector3 position)
    {
        Debug.Log($"User has clicked at {position}");

        driver.GotToPos(position);
    }
}
