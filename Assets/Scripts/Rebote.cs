using UnityEngine;

public class Rebote : MonoBehaviour
{
    public float fuerzaRebote = 10f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rbJugador = collision.collider.GetComponent<Rigidbody2D>();
        MovimientoJugador jugador = collision.collider.GetComponent<MovimientoJugador>();

        if (rbJugador != null && jugador != null)
        {
            rbJugador.linearVelocity = new Vector2(fuerzaRebote, fuerzaRebote);
            jugador.tiempoRebote = 0.3f;
        }
    }
}