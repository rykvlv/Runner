using UnityEngine;

public class CoreManager : Singleton<CoreManager>
{
    private bool _isGameStarted = false;

    private void Awake()
    {
        //_playerManager.Animate("Run State");
    }

    private void Start()
    {
        //_mapManager = new MapManager();
    }

    private void Update()
    {
        if (_isGameStarted)
        {
            MapManager.instance.MoveMap();
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            _isGameStarted = true;
            PlayerManager.instance.Animate("RunAnimation");
        } else if (Input.GetKeyUp(KeyCode.Space))
        {
            _isGameStarted = false;
            PlayerManager.instance.Animate("IdleAnimation");
        }

        if (Input.GetKey(KeyCode.A) && PlayerManager.instance.GetPlayer().transform.position.x > -3f)
        {
            PlayerManager.instance.GetPlayer().transform.Translate(new Vector3(-0.1f, 0f, 0f), Space.World);
        } else if (Input.GetKey(KeyCode.D) && PlayerManager.instance.GetPlayer().transform.position.x < 3f)
        {
            PlayerManager.instance.GetPlayer().transform.Translate(new Vector3(0.1f, 0f, 0f), Space.World);
        }
    } 
}
