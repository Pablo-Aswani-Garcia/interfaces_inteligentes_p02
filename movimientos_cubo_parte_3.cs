using UnityEngine;

public class movimientos_cubo_parte_3 : MonoBehaviour {
  public float speed = 2.0f;
  public float rotationSpeed = 90.0f;
  public Vector3 moveDirection = new Vector3(1, 0, 0);
  GameObject sphere;
  void MoveCubeTowardsSphere() {
    if (sphere != null) {
      Vector3 directionToSphere = sphere.transform.position - transform.position;
      directionToSphere.y = 0;
      if (directionToSphere != Vector3.zero) {
        moveDirection = directionToSphere.normalized;
        Vector3 lookTarget = sphere.transform.position;
        lookTarget.y = transform.position.y;
        transform.LookAt(lookTarget);
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
      }
    }
  }
  void Start(){ 
    transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    sphere = GameObject.FindWithTag("target");
  }
  void RotateCubeWithInput() {
    float horizontalInput = Input.GetAxis("Horizontal");
    transform.Rotate(0, horizontalInput * rotationSpeed * Time.deltaTime, 0);
    transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
      
  }
  void Update() {
    MoveCubeTowardsSphere();
    RotateCubeWithInput();
  }


}

