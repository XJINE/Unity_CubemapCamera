using UnityEngine;

public class Sample : MonoBehaviour
{
    [SerializeField]
    private RenderTexture cubemap;

    public void OnUpdateCubemap(RenderTexture cubemap)
    {
        // NOTE:
        // Set into CubemapCamera.OnUpdate.
        this.cubemap = cubemap;
    }
}