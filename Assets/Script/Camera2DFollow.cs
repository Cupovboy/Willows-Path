using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
	public class Camera2DFollow : MonoBehaviour
	{
		public Transform target;
		public float damping = 0;
		public float lookAheadFactor = 0;
		public float lookAheadReturnSpeed = 0;
		public float lookAheadMoveThreshold = 0;
		public float xResRight = 10;
		public float xResLeft = 0;
		public float yResUp = 10;
		public float yResDown = 0;


		private float m_OffsetZ;
		private Vector3 m_LastTargetPosition;
		private Vector3 m_CurrentVelocity;
		private Vector3 m_LookAheadPos;

		float NextTimeToSearch = 0;

		// Use this for initialization
		private void Start()
		{
			m_LastTargetPosition = target.position;
			m_OffsetZ = (transform.position - target.position).z;
			transform.parent = null;
		}


		// Update is called once per frame
		private void Update()
		{

			if (target == null) {
				FindPlayer ();
				return;
			}

			// only update lookahead pos if accelerating or changed direction
			float xMoveDelta = (target.position - m_LastTargetPosition).x;

			bool updateLookAheadTarget = Mathf.Abs(xMoveDelta) > lookAheadMoveThreshold;

			if (updateLookAheadTarget)
			{
				m_LookAheadPos = lookAheadFactor*Vector3.right*Mathf.Sign(xMoveDelta);
			}
			else
			{
				m_LookAheadPos = Vector3.MoveTowards(m_LookAheadPos, Vector3.zero, Time.deltaTime*lookAheadReturnSpeed);
			}

			Vector3 aheadTargetPos = target.position + m_LookAheadPos + Vector3.forward*m_OffsetZ;
			Vector3 newPos = Vector3.SmoothDamp(transform.position, aheadTargetPos, ref m_CurrentVelocity, damping);

			newPos = new Vector3 (Mathf.Clamp (newPos.x, xResLeft, xResRight), Mathf.Clamp (newPos.y, yResDown, yResUp), newPos.z);

			transform.position = newPos;

			m_LastTargetPosition = target.position;
		}

		void FindPlayer () {
			if (NextTimeToSearch <= Time.time) {
				GameObject searchResult = GameObject.FindGameObjectWithTag ("Player");

				if (searchResult != null) {
					target = searchResult.transform;
				}

				NextTimeToSearch = Time.time + 0.5f;
			}
		}
	}
}
