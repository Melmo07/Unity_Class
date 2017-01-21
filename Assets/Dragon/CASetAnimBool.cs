using UnityEngine;
using System.Collections;

public class CASetAnimBool : CustomActionScript {

	public Animator _animatorTarget;
	public string _animBoolName;
	public bool _animBoolValue = true;


	public override void OnDrawGizmos()
	{
		base.OnDrawGizmos();

		if (_animatorTarget != null)
			Debug.DrawLine(this.transform.position, _animatorTarget.transform.position, Color.blue);

	}

	public override IEnumerator DoActionOnEvent (MonoBehaviour sender, GameObject args)
	{
		yield return new WaitForFixedUpdate();
		if (_animatorTarget != null) {
			_animatorTarget.SetBool (_animBoolName, _animBoolValue); 
		}
		yield return null;
	}

}
