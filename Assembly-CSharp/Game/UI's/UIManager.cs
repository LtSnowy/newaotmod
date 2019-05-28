using UnityEngine; 

class UIManager
{
    [ExecuteInEditMode, AddComponentMenu("NGUI/UI/Label")]
    public class UILabel : MonoBehaviour
    {
        #region definers

        private string mText = string.Empty;

        private bool mBeProcessed = true;

        private string mLastText = string.Empty;

        private int mLastWidth;

        private readonly int mMaxLineWidth;

        private bool mLastEncoding = true;

        private readonly bool mEncoding = true;

        private int mLastCount;

        private readonly int mMaxLineCount;

        private bool mLastPass;

        private readonly bool mPassword;

        private bool mLastShow;

        private readonly bool mShowLastChar;

        private Effect mLastEffect;

        private readonly Effect mEffectStyle;

        protected bool mChanged = true;

        private bool mShrinkToFit;

        #endregion

        private bool HasChanged
        {
            get
            {
                return ((((this.mBeProcessed || (this.mLastText != this.Text)) || ((this.mLastWidth != this.mMaxLineWidth) || (this.mLastEncoding != this.mEncoding))) || (((this.mLastCount != this.mMaxLineCount) || (this.mLastPass != this.mPassword)) || (this.mLastShow != this.mShowLastChar))) || (this.mLastEffect != this.mEffectStyle));
            }
            set
            {
                if (value)
                {
                    mChanged = true;
                    this.mBeProcessed = true;
                }
                else
                {
                    this.mBeProcessed = false;
                    this.mLastText = this.Text;
                    this.mLastWidth = this.mMaxLineWidth;
                    this.mLastEncoding = this.mEncoding;
                    this.mLastCount = this.mMaxLineCount;
                    this.mLastPass = this.mPassword;
                    this.mLastShow = this.mShowLastChar;
                    this.mLastEffect = this.mEffectStyle;
                }
            }
        }

        public bool ShrinkToFit
        {
            get
            {
                return this.mShrinkToFit;
            }
            set
            {
                if (this.mShrinkToFit != value)
                {
                    this.mShrinkToFit = value;
                    this.HasChanged = true;
                }
            }
        }
        
        public string Text
        {
            get
            {
                return this.mText;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    if (!string.IsNullOrEmpty(this.mText))
                    {
                        this.mText = string.Empty;
                    }
                    this.HasChanged = true;
                }
                else if (this.mText != value)
                {
                    this.mText = value;
                    this.HasChanged = true;
                    if (this.ShrinkToFit)
                    {

                    }
                }
            }
        }

        public enum Effect
        {
            None,
            Shadow,
            Outline
        }
    }


}