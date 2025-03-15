using FishNet.Object;

public abstract class View : NetworkBehaviour
{
    public bool IsInitialized { get; private set; }


    public virtual void Initialize()
    {
        IsInitialized = true;
    }

    public virtual void Show(object args = null)
    {
        gameObject.SetActive(true);
    }

    public virtual void Hide()
    {
        gameObject.SetActive(false);
    }
}
