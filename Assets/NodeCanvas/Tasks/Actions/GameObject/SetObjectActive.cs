using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions{

	[Name("Set Visibility")]
	[Category("GameObject")]
	public class SetObjectActive : ActionTask<Transform> {

		public enum SetActiveMode
		{
			Deactivate = 0,
			Activate   = 1,
			Toggle     = 2
		}

		public SetActiveMode setTo = SetActiveMode.Toggle;

		protected override string info{
			get {return string.Format("{0} GameObject", setTo.ToString());}
		}

		protected override void OnExecute(){

			bool value;
			
			if (setTo == SetActiveMode.Toggle){
			
				value = !agent.gameObject.activeSelf;
			
			} else {

				value = (int)setTo == 1;
			}

			agent.gameObject.SetActive(value);
			EndAction();
		}
	}
}