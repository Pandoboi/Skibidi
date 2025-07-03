using UnityEngine;
using PurrNet;
public class TestingScript : NetworkIdentity
{
    [SerializeField] private Color _color;
    [SerializeField] private Renderer _renderer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            SetColor(_color);
    }

    [ObserversRpc]

    private void SetColor(Color color)
    {
        _renderer.material.color = _color;
    }
}
