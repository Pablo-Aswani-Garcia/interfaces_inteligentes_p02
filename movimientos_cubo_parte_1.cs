using UnityEngine;

public class movimientos_cubo_parte_1 : MonoBehaviour {
    public Vector3 moveDirection = new Vector3(1, 0, 0); 
    public float speed = 1.0f; 
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
    void Start()
    {
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }

    void Update()
    {
        CalcularFlecha(); 
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
