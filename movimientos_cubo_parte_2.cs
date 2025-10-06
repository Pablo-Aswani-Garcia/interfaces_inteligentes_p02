using UnityEngine;

public class movimientos_cubo_parte_2 : MonoBehaviour {
    public Vector3 moveDirection = new Vector3(1, 0, 0); 
    public float speed = 2.0f; 
    void Start()
    {
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }
    void CalcularFlecha()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Flecha Arriba: " + (speed * Input.GetAxis("Vertical")));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Flecha Abajo: " + (speed * Input.GetAxis("Vertical")));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Flecha Izquierda: " + (speed * Input.GetAxis("Horizontal")));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Flecha Derecha: " + (speed * Input.GetAxis("Horizontal")));
        }
    }
    void Update()
    {
        CalcularFlecha(); 
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveDirection = new Vector3(0, 0, 1); 
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveDirection = new Vector3(0, 0, -1); 
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveDirection = new Vector3(-1, 0, 0); 
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveDirection = new Vector3(1, 0, 0);
        }
        

        
       
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
