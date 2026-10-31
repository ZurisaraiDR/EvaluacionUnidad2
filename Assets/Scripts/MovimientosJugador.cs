using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoJugador : MonoBehaviour
{
    private Rigidbody2D rb;

    [Header("Configuración")]
    public float velocidad = 5f;
    public float fuerzaSalto = 8f;

    [HideInInspector] public float tiempoRebote;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (tiempoRebote > 0)
        {
            tiempoRebote -= Time.deltaTime;
            return;
        }

        Keyboard teclado = Keyboard.current;
        if (teclado == null) return;

        float movimientoH = 0f;
        if (teclado.aKey.isPressed || teclado.leftArrowKey.isPressed) movimientoH = -1f;
        if (teclado.dKey.isPressed || teclado.rightArrowKey.isPressed) movimientoH = 1f;

        rb.linearVelocity = new Vector2(movimientoH * velocidad, rb.linearVelocity.y);

        if (teclado.wKey.wasPressedThisFrame || teclado.upArrowKey.wasPressedThisFrame)
        {
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
    }

}