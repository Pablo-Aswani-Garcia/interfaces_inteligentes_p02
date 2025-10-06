using UnityEditor;
using UnityEngine;

public class random_color : MonoBehaviour {
  public int frames_update = 400;
  public Vector3 color;
  void Start() {
      
  }
  void Update() {
    if (Time.frameCount % frames_update == 0) {
      
      color.x = Random.Range(0.0f, 1.0f);
      color.y = Random.Range(0.0f, 1.0f);
      color.z = Random.Range(0.0f, 1.0f);
      GetComponent<Renderer>().material.color = new Color(color.x, color.y, color.z);
    }
  }
}
