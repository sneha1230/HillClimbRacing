using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarMovement : MonoBehaviour
{
    public static CarMovement carinstance;
    public Rigidbody2D BackTire, FrontTire, Car;
    public float speed, movement;
    public float fuel, FuelConsumption;
    public Image fuelImage;
    // Start is called before the first frame update
    private void Awake()
    {
        carinstance = this;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        fuelImage.fillAmount = fuel;
        //movement = 0;
    }
    private void FixedUpdate()
    {
        if (fuel > 0)
        {
            BackTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            FrontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            Car.AddTorque(-movement * speed * Time.fixedDeltaTime);

        }
        fuel = fuel - FuelConsumption * Time.deltaTime * Mathf.Abs(movement);
    }
    /*public void Gas()
    {
        movement = 1f;
    }
    public void Brake()
    {
        movement = 0f;
    }*/


}
