using UnityEngine;

public class Nieve : MonoBehaviour
{

    public Vector3 posicion;
    public float vida = 200f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        QuitarVida();
        QuitarVida();
        RegenerarVida();
    }

    void Movimiento() 
    {
        transform.position += posicion * Time.deltaTime;

    }

    void QuitarVida() 
    {
        vida --;
        Debug.Log("vida: "+ vida);
      
    }

    void RegenerarVida()
    {
        vida++; 

    }
}
