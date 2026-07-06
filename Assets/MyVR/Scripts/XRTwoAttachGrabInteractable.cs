using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace MyVR
{
    /// <summary>
    /// 잡는 손에 따라 왼손, 오른손 어태치포인트 다르게 설정
    /// </summary>
    public class XRTwoAttachGrabInteractable : XRGrabInteractable
    {
        #region Variables
        public Transform leftAttachTransform;
        public Transform rightAttachTransform;
        #endregion

        #region Unity Event Method
        protected override void OnSelectEntered(SelectEnterEventArgs args)
        {
            if(args.interactorObject.transform.CompareTag("LeftHand"))
            {
                attachTransform = leftAttachTransform;
            }
            else if (args.interactorObject.transform.CompareTag("RightHand"))
            {
                attachTransform = rightAttachTransform;
            }

            base.OnSelectEntered(args);
        }
        #endregion
    }
}