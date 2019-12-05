using UnityEngine;

public class Sample : MonoBehaviour
{
    [SerializeField]
    private RenderTexture cubemap;

    private CubemapCamera cubemapCamera;

    public void Start()
    {
        this.cubemapCamera = FindObjectOfType<CubemapCamera>();
        this.cubemapCamera.Initialize();
        this.cubemap = this.cubemapCamera.Cubemap;
    }

    public void Update()
    {
        this.cubemap = this.cubemapCamera.Cubemap;
    }
}