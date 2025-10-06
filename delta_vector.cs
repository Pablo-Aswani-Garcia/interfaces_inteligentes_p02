using UnityEngine;

public class delta_vector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector3 delta_vector_value;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") != 0)
        {
            transform.position += delta_vector_value;
        }
        
    }
}
