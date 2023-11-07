using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonController : MonoBehaviour
{
    public float BlastPower = 5;
    public GameObject Cannonball;
    public Transform ShotPoint;

    public Slider angleSlider;
    public Slider inclinationSlider;
    public Text angleText;
    public Text inclinationText;

    private void Update()
    {
      float angle = angleSlider.value;
      float inclination = inclinationSlider.value;

      angleText.text = "Ángulo: " + angle.ToString("F1");
      inclinationText.text = "Inclinación: " + inclination.ToString("F1");
      transform.rotation = Quaternion.Euler(0, angle, inclination);

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Proyectile();
        }
    }

    public void Proyectile()
    {
        GameObject createdCannonball = Instantiate(Cannonball, ShotPoint.position, ShotPoint.rotation);
        Rigidbody cannonballRb = createdCannonball.GetComponent<Rigidbody>();
        Vector3 shootDirection = ShotPoint.up;
        cannonballRb.AddForce(shootDirection * BlastPower, ForceMode.Impulse);
        Destroy(createdCannonball, 2f);
    }
}
