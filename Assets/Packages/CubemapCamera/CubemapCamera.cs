using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Camera))]
public class CubemapCamera : MonoBehaviour
{
    [System.Flags]
    public enum FaceMask
    {
        Right  = 1,
        Left   = 1 << 1,
        Top    = 1 << 2,
        Bottom = 1 << 3,
        Front  = 1 << 4,
        Back   = 1 << 5
    }

    [System.Serializable]
    public class TextureEvent : UnityEvent<RenderTexture> { };

    #region Field

    [SerializeField] protected int      resolution = 4096; // 2^
    [SerializeField] protected int      depth      =   24; // 0, 16, 24
    [SerializeField] protected FaceMask faceMask   = FaceMask.Right | FaceMask.Left
                                                   | FaceMask.Top   | FaceMask.Bottom
                                                   | FaceMask.Front | FaceMask.Back;

    public TextureEvent OnUpdate;

    private new Camera camera;

    #endregion Field

    #region Property

    public int Resolution
    {
        get { return this.resolution; }
        set
        {
            if (value != 0 && value != this.resolution && Mathf.IsPowerOfTwo(value))
            {
                this.resolution = value;
                InitializeCubemap();
            }
        }
    }

    public int Depth
    {
        get { return this.depth; }
        set
        {
            if ((value == 0 || value == 16 || value == 24) && value != this.depth)
            {
                this.depth = value;
                InitializeCubemap();
            }
        }
    }

    public RenderTexture Cubemap { get; protected set; }

    #endregion Property

    #region Method

    protected virtual void Awake()
    {
        this.camera = GetComponent<Camera>();
        this.InitializeCubemap();
    }

    protected virtual void LateUpdate()
    {
        // NOTE:
        // Do not in Upddate().

        this.camera.RenderToCubemap(this.Cubemap, (int)this.faceMask);
        this.OnUpdate.Invoke(this.Cubemap);
    }

    protected virtual void OnDisable()
    {
        Destroy(this.Cubemap);
    }

    public void InitializeCubemap()
    {
        this.Cubemap = new RenderTexture(this.resolution,
                                         this.resolution,
                                         this.depth,
                                         RenderTextureFormat.ARGB32)
        {
            dimension = UnityEngine.Rendering.TextureDimension.Cube,
            hideFlags = HideFlags.HideAndDontSave
        };
    }

    #endregion Method
}