using UnityEngine;

public class distancia : MonoBehaviour
{
    public GameObject objeto_1;
    public GameObject objeto_2;
    public float frames_update;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frames_update = GetComponent<random_color>().frames_update;
        if (Time.frameCount % frames_update == 0)
        {
            float distance = Vector3.Distance(objeto_1.transform.position, objeto_2.transform.position);
            Debug.Log("Distance between object 1 and object 2: " + distance);
        }
        
    }
}
