using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotateSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
	{
		MovePlayer();
    }

	void MovePlayer(){
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
        transform.Translate(zValue,0,0);
		transform.Rotate(0,xValue,0);
	}
}
