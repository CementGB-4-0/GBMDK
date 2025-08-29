using Femur;
using GB.Game.Critters;
using UnityEngine;

public class NaughtyPlayersPunisher : MonoBehaviour
{
	public float tickRate;

	[Space]
	public float allowedNaughtyTime;

	public float variance;

	public float reductionAfterTriggering;

	[Header("Playable Areas")]
	[Space]
	public bool punishPlayersBelowPlayArea;

	public float lowestPlayableHeight;

	[Space]
	public bool punishPlayersAbovePlayArea;

	public float highestPlayableHeight;

	[Space]
	public bool punishPlayersInNaughtyZones;

	public Transform[] naughtyZones;

	[Header("Punishments")]
	[Space]
	public bool disableGrip;

	[Space]
	public bool useBirds;

	public int minBirds;

	public int maxBirds;

	[Space]
	public bool useRats;

	public int minRats;

	public int maxRats;

	[Space]
	public bool useFish;

	public int minFish;

	public int maxFish;

	private Actor[] actors;

	private float[] naughtyPlayerTimers;

	private BirdActor[] birds;

	private void Start()
	{
	}

	private void FindActors()
	{
	}

	private void FindBirds()
	{
	}

	private void FindNaughtyPlayers()
	{
	}
}
