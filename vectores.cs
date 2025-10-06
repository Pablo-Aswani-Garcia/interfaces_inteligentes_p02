using Unity.VisualScripting;
using UnityEngine;

public class vectores : MonoBehaviour
{
    public Vector3 vector_1;
    public Vector3 vector_2;
    public int frames_update;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Magnitude()
    {
        float magnitude_vector_1 = vector_1.magnitude;
        float magnitude_vector_2 = vector_2.magnitude;
        Debug.Log("Magnitude of vector 1: " + magnitude_vector_1);
        Debug.Log("Magnitude of vector 2: " + magnitude_vector_2);
    }
    void Angle()
    {
        float angle = Vector3.Angle(vector_1, vector_2);
        Debug.Log("Angle between vector 1 and vector 2: " + angle);
    }
    void Distance()
    {
        float distance = Vector3.Distance(vector_1, vector_2);
        Debug.Log("Distance between vector 1 and vector 2: " + distance);
    }
    void Height()
    {
        if (vector_1.y > vector_2.y)
        {
            Debug.Log("Vector 1 is higher than Vector 2");
        }
        else if (vector_1.y < vector_2.y)
        {
            Debug.Log("Vector 2 is higher than Vector 1");
        }
        else
        {
            Debug.Log("Vector 1 and Vector 2 are at the same height");
        }
    }
    void LocSphere()
    {
        Vector3 loc_sphere = transform.position;
        Debug.Log("Location of the sphere: " + loc_sphere);
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        frames_update = GetComponent<random_color>().frames_update;
        if (Time.frameCount % frames_update == 0)
        {
            Magnitude();
            Angle();
            Distance();
            Height();
            LocSphere();
        }
    }
}
