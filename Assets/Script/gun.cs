using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform MuzzleTransform;
    public Camera cam;

    private Vector3 mousePos;
    private Vector2 gunDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        gunDirection = (mousePos - transform.position).normalized;
        float angle = Mathf.Atan2(gunDirection.y, gunDirection.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("???갴??");
            //create a bullet
            Instantiate(bullet, MuzzleTransform.position, Quaternion.Euler(MuzzleTransform.eulerAngles));
        }
    }
}
