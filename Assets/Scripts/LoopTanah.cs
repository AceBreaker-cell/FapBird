using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class LoopTanah : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _width = 6f;

    private SpriteRenderer _spriteRenderer;

    private UnityEngine.Vector2 _StartSize;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _StartSize = new UnityEngine.Vector2(_spriteRenderer.size.x, _spriteRenderer.size.y);
    }

    private void Update()
    {
        _spriteRenderer.size = new UnityEngine.Vector2(_spriteRenderer.size.x + _speed * Time.deltaTime, _spriteRenderer.size.y);

        if (_spriteRenderer.size.x > _width)
        {
            _spriteRenderer.size = _StartSize;
        }
    }
}