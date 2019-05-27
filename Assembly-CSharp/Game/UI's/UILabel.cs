using UnityEngine;

[ExecuteInEditMode, AddComponentMenu("NGUI/UI/Label")]
public class UILabel : MonoBehaviour
{

    private string mText = string.Empty;

    private bool mBeProcessed = true;

    private string mLastText = string.Empty;

    private int mLastWidth;

    private int mMaxLineWidth;

    private bool mLastEncoding = true;

    private bool mEncoding = true;

    private int mLastCount;

    private int mMaxLineCount;

    private bool mLastPass;

    private bool mPassword;

    private bool mLastShow;

    private bool mShowLastChar;

    private Effect mLastEffect;

    private Effect mEffectStyle;

    protected bool mChanged = true;

    private bool mShrinkToFit;

    private bool hasChanged
    {
        get
        {
            return ((((this.mBeProcessed || (this.mLastText != this.text)) || ((this.mLastWidth != this.mMaxLineWidth) || (this.mLastEncoding != this.mEncoding))) || (((this.mLastCount != this.mMaxLineCount) || (this.mLastPass != this.mPassword)) || (this.mLastShow != this.mShowLastChar))) || (this.mLastEffect != this.mEffectStyle));
        }
        set
        {
            if(value)
            {
                mChanged = true;
                this.mBeProcessed = true;
            }
            else
            {
                this.mBeProcessed = false;
                this.mLastText = this.text;
                this.mLastWidth = this.mMaxLineWidth;
                this.mLastEncoding = this.mEncoding;
                this.mLastCount = this.mMaxLineCount;
                this.mLastPass = this.mPassword;
                this.mLastShow = this.mShowLastChar;
                this.mLastEffect = this.mEffectStyle;
            }
        }
    }

    public bool shrinkToFit
    {
        get
        {
            return this.mShrinkToFit;
        }
        set
        {
            if(this.mShrinkToFit != value)
            {
                this.mShrinkToFit = value;
                this.hasChanged = true;
            }
        }
    }

    

    public string text
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
                this.hasChanged = true;
            }
            else if (this.mText != value)
            {
                this.mText = value;
                this.hasChanged = true;
                if(this.shrinkToFit)
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
