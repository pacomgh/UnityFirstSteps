using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    //public float speed;

    //se sustituye en lugar de la velocidad
    public float forceValue;

    //variable para uso de la fisica en cuerpos rigidos
    private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
        //cacha las referencias una vez que inicia el juego
        //en la variable rigidbody almacenamos el componente y lo almacenamos en la variable
        //getcomponent nos permite acceder a los componentes de un gameobject
        rigidBody = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
    //metodo que se llama cada vez que se refresca la pantalla, es decir que se ejecuta tantaas bveces como frames por segundo
	void Update () {
        //se mueve n cantidad de metreo en n cantidad de tiempo en n velocidad
       /* transform.Translate (Input.GetAxis("Horizontal")*speed*Time.deltaTime,
                            0,
                            Input.GetAxis("Vertical")*speed*Time.deltaTime);*/
	
	}

    //se ejecuta en un tiempo regular, por ejemplo 50 veces por segundo, tiene codigo sincronizado con el motor fisico
    void FixedUpdate() {
        //aplica una fuerza a la esfera, aplica fuerza en base al tecleo de las flechas, fuerza constante
        //debe ser codigo optimizado

        //al cuerpo que tenemos le agregamos una fuerza en un vector de 3 ejes, se mueve en horizontal en x y en vertical en y
        rigidBody.AddForce(new Vector3(Input.GetAxis("Horizontal"),
                            0,
                            Input.GetAxis("Vertical")));
        
    }


}
