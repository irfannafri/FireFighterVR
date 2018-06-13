using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Camera kamera;
    public float speed = 6.0F;
    //public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public Vector3 moveDirection = Vector3.zero;

	/*void Start()
	{
//		m_AudioSource = GetComponent<GvrAudioSource> ();
	}*/
	public void Update()
	{
		//m_AudioSource = GetComponent<GvrAudioSource> ();
		CharacterController controller = GetComponent<CharacterController> ();

		if (controller.isGrounded) {
			Vector3 forward = kamera.transform.TransformDirection (Vector3.forward);
			forward.y = 0;
			forward = forward.normalized;
			Vector3 right = new Vector3 (forward.z, 0, -forward.x);
			float h = Input.GetAxis ("Horizontal");
			float v = Input.GetAxis ("Vertical");
			moveDirection = (h * right + v * forward);
			//moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

			moveDirection = transform.TransformDirection (moveDirection);
			moveDirection *= speed;
			//if (Input.GetButton("Jump"))
			//    moveDirection.y = jumpSpeed;

		}

		transform.Rotate (0, transform.localEulerAngles.y, 0);
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move (moveDirection * Time.deltaTime);

		/*void Late(Vector3 moveDirection)
		{
			AudioClip temp;
			if(!m_AudioSource.isPlaying&&(moveDirection.x!=0||moveDirection.z!=0))
			{
				int n = Random.Range(1, m_FootstepSounds.Length);
				m_AudioSource.clip = m_FootstepSounds [n];

				m_AudioSource.PlayOneShot (m_AudioSource.clip);
				m_FootstepSounds [n] = m_FootstepSounds [0];
				m_FootstepSounds [0] = m_AudioSource.clip;
			}
		}*/
	}
}
