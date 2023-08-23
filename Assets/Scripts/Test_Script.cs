using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Script : MonoBehaviour
{
    public List<Color> color;
    public MeshRenderer meshRenderer;
    public float delayTime;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
       //for (int i = 0; i < color.Count; i++)
       // {
       //     meshRenderer.material.color = color[Random.Range(0, color.Count)];
       // }
    }

    // Update is called when pressing play
    private void OnEnable()
    {
        //ChangeColor();
    }

    // Update is called when pressed stop(?)
    private void OnDisable()
    {

    }

    //Changes color when pressing the mouse
    private void OnMouseDown()
    {
        //Changes color with a time delay
        //Invoke("ChangeColor", delayTime);

        //Changes color with a time delay and repeats every 1 second
        InvokeRepeating("ChangeColor", 5,1);

        //To cancel InvokeRepeating
        //CancelInvoke();
    }

    //Changes color when cursor touches the object
    private void OnMouseEnter()
    {
        //ChangeColor();
    }

    //Changes color after removing the cursor from the object
    private void OnMouseExit()
    {
        //ChangeColor();
    }

    //Changes color rapidly when the cursor is touching the object
    private void OnMouseOver()
    {
        //ChangeColor();
    }

    //Changes color rapidly when clicking/holding the mouse button
    private void OnMouseDrag()
    {
        //ChangeColor();
    }

    //Changes color rapidly when clicking/holding the mouse button
    private void OnMouseUpAsButton()
    {
        //ChangeColor();
    }

    public void ChangeColor()
    {
        for (int i = 0; i < color.Count; i++)
        {
            meshRenderer.material.color = color[Random.Range(0, color.Count)];
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    // Is called 50 times per second
    void FixedUpdate()
    {

    }

    // Is called 50 times per second
    void LateUpdate()
    {

    }
}
