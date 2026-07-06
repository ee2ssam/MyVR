using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace MyVR
{
    public class XROffsetGrabInteractable : XRGrabInteractable
    {
        #region Variables
        //잡히는 오브젝트
        private GameObject attachPoint;
        #endregion

        #region Unity Event Method
        private void Start()
        {
            if(attachTransform == null)
            {
                attachPoint = new GameObject("Offset Grab Pivot");
                attachPoint.transform.SetParent(this.transform, false);
                attachTransform = attachPoint.transform;
            }
        }

        protected override void OnSelectEntered(SelectEnterEventArgs args)
        {
            attachTransform.position = args.interactorObject.transform.position;
            attachTransform.rotation = args.interactorObject.transform.rotation;

            base.OnSelectEntered(args);
        }
        #endregion

    }
}