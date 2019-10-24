using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRandomMovement : MonoBehaviour
{
  private Rigidbody rb;         // Contiene la componente Rigidbody.
	private int minSpeed = 400;		// Mínima velocidad de la esfera
	private int maxSpeed = 800;		// Máxima velocidad de la esfera

  public float groundThrust;    // Indica la fuerza a aplicar para
                                // el movimiento en los ejes X y Z.
	// Use this for initialization
	void Start () {
		  rb = gameObject.GetComponent<Rigidbody>();
	}


  void Update () {

			float randomSeedZ = Random.Range(0,10);
			float randomSeedX = Random.Range(0,10);

			if(randomSeedZ < 5){
				if(randomSeedX > 5){
					rb.AddForce(Vector3.forward * Random.Range(minSpeed,maxSpeed) * Time.deltaTime);
					rb.AddForce(Vector3.right * Random.Range(minSpeed,maxSpeed) * Time.deltaTime);
				}else{
					rb.AddForce(Vector3.forward * Random.Range(minSpeed,maxSpeed) * Time.deltaTime);
					rb.AddForce(Vector3.left * Random.Range(minSpeed,maxSpeed) * Time.deltaTime);
				}
			}else{
				if(randomSeedX > 5){
					rb.AddForce(Vector3.back * Random.Range(minSpeed,maxSpeed) * Time.deltaTime);
					rb.AddForce(Vector3.right * Random.Range(minSpeed,maxSpeed) * Time.deltaTime);
				}else{
					rb.AddForce(Vector3.back * Random.Range(minSpeed,maxSpeed) * Time.deltaTime);
					rb.AddForce(Vector3.left * Random.Range(minSpeed,maxSpeed) * Time.deltaTime);
				}
			}

	}
}
