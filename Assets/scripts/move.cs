using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    //public float speed;

    //se sustituye en lugar de la velocidad
    public float forceValue;
    public float jumpValue;
    //añadimos una variable para audio
    private AudioSource audioJump;

    //variable para uso de la fisica en cuerpos rigidos
    private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
        //cacha las referencias una vez que inicia el juego
        //en la variable rigidbody almacenamos el componente y lo almacenamos en la variable
        //getcomponent nos permite acceder a los componentes de un gameobject
        rigidBody = GetComponent<Rigidbody>();
        //asiganmos nuestra variable audio a un componente de audio
        audioJump = GetComponent<AudioSource>();
	
	}

    // Update is called once per frame
    //metodo que se llama cada vez que se refresca la pantalla, es decir que se ejecuta tantaas bveces como frames por segundo
    void Update()
    {
        //se mueve n cantidad de metreo en n cantidad de tiempo en n velocidad
        /* transform.Translate (Input.GetAxis("Horizontal")*speed*Time.deltaTime,
                             0,
                             Input.GetAxis("Vertical")*speed*Time.deltaTime);*/

        //haremos saltar nuestra esfera
        //se usa get button down para detectar el boton solamente cuando es presionado, solo la primera vez
        //se usa jump porque esta mapeado como la spacebar, comprobamos que este en reposo y que no pueda saltar dos veces
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigidBody.velocity.y) < 0.01f) {
            //añadimos una fuerza al cuerpo en el vector 3, es decir en y, y le aplicamos un valor de salto, como segundo parametro
            //agregamos una fuerza para adquirir una velocidad instantanea
            rigidBody.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
            //reproduccion del audio
            audioJump.Play();
    }	
	}

    //se ejecuta en un tiempo regular, por ejemplo 50 veces por segundo, tiene codigo sincronizado con el motor fisico
    void FixedUpdate() {
        //aplica una fuerza a la esfera, aplica fuerza en base al tecleo de las flechas, fuerza constante
        //debe ser codigo optimizado

        //al cuerpo que tenemos le agregamos una fuerza en un vector de 3 ejes, se mueve en horizontal en x y en vertical en z
        rigidBody.AddForce(new Vector3(Input.GetAxis("Horizontal"),
                            0,
                            Input.GetAxis("Vertical")));
        
    }


}
