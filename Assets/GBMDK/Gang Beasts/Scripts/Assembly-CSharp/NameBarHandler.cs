using CS.CorePlatform;
using Femur;
using GB.Networking.Objects;
using GB.Platform.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameBarHandler : MonoBehaviour
{
	private static readonly Vector3 TOP_LEFT_DUMMY_POS;

	private static readonly Vector3 TOP_RIGHT_DUMMY_POS;

	private static readonly Vector3 BOTTOM_DUMMY_POS;

	private static readonly float NAMEBAR_CRED_UPDATE_INTERVAL;

	private BaseUserInfo _userInfo;

	private float updateTimer;

	[SerializeField]
	private Canvas CanvasRef;

	[SerializeField]
	public TextMeshProUGUI CachedNameText;

	[SerializeField]
	public MicActiveIconHandler CachedMicIcon;

	[SerializeField]
	public Image _NameBarImage;

	[SerializeField]
	private float _uiDeapth;

	public bool ShowName;

	protected Actor _CachedActorRef;

	protected NetBeast _CachedNetBeast;

	private Vector3 cachedScreenPos;

	private Vector3 cachedLocalPos;

	public BaseUserInfo User => default(BaseUserInfo);

	public bool VOIPActive => false;

	public void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void LateUpdate()
	{
	}

	private void UpdatePosition()
	{
	}

	private Quaternion GetForwardRotation()
	{
		return default(Quaternion);
	}

	public void SetToNetBeast(NetBeast beast)
	{
	}

	private void UpdateWithCurrentBeast()
	{
	}

	private void UpdateBeastInfo()
	{
	}

	private void UpdateColour()
	{
	}

	private void UpdatePlatform(NetPlatform platform)
	{
	}

	private void UpdateNameTag(NetPlatform platform)
	{
	}

	private void UpdateMic(NetPlatform platform)
	{
	}

	public void ChangeColour(Color colour)
	{
	}

	public virtual void OnActivation()
	{
	}

	public void SetToUser(NetPlatform platform, Vector3 screenSpacePos, int controller)
	{
	}
}
