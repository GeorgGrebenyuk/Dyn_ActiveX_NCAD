﻿using DynNCXLib.GeometryWrapper;

namespace DynNCXLib 
{

    ///<summary>
    /// An object appearing as a text string that describes the characteristics of an attribute reference. In AutoCAD, this object is called an attribute definition
    ///</summary>
    public class AcadAttribute 
	{
		public OdaX.AcadAttribute _i;
		internal AcadAttribute(object AcadAttribute_object) 
		{
			this._i = AcadAttribute_object as OdaX.AcadAttribute;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

        /// <summary>
        /// Creates an attribute definition at the given location with the specified properties
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="Height">The text height in the current drawing unit</param>
        /// <param name="Mode">AcAttributeMode enum</param>
        /// <param name="Prompt">This string appears when a block containing this attribute is inserted. The default for this string is the Tag string. Inputting acAttributeModeConstant for the Mode parameter disables the prompt</param>
        /// <param name="InsertionPoint">The 3D WCS coordinates specifying the location for the attribute</param>
        /// <param name="Tag">This non-null string identifies each occurrence of the attribute. Enter any characters except spaces or exclamation points. AutoCAD changes lowercase letters to uppercase</param>
        /// <param name="Value">This non-null string is the default attribute value</param>
        public AcadAttribute (AcadBlock AcadBlock, double Height, 
			OdaX.AcAttributeMode Mode, string Prompt, Point InsertionPoint, string Tag, string Value)
        {
            this._i = AcadBlock._i.AddAttribute(Height, Mode, Prompt, Technical.PointByDynPoint(InsertionPoint), Tag, Value);
        }

        ///<summary>
        ///Specifies the field length of the attribute
        ///</summary>
        public int FieldLength => this._i.FieldLength;

        ///<summary>
        ///Specifies the field length of the attribute
        ///</summary>
        public void Set_FieldLength(int fieldLen) 
		{
			this._i.FieldLength = fieldLen;
		}

        ///<summary>
        ///Specifies the tag string of the object
        ///</summary>
        public string TagString => this._i.TagString;

        ///<summary>
        ///Specifies the tag string of the object
        ///</summary>
        public void Set_TagString(string Tag) 
		{
			this._i.TagString = Tag;
		}

        ///<summary>
        ///Specifies the prompt string for an attribute
        ///</summary>
        public string PromptString => this._i.PromptString;

        ///<summary>
        ///Specifies the prompt string for an attribute
        ///</summary>
        public void Set_PromptString(string bstrPrompt) 
		{
			this._i.PromptString = bstrPrompt;
		}

        ///<summary>
        ///Specifies the text string for the entity
        ///</summary>
        public string TextString => this._i.TextString;

        ///<summary>
        ///Specifies the text string for the entity
        ///</summary>
        public void Set_TextString(string bstrText) 
		{
			this._i.TextString = bstrText;
		}

        ///<summary>
        ///Specifies the name of the style used with the object
        ///</summary>
        public string StyleName => this._i.StyleName;

        ///<summary>
        ///Specifies the name of the style used with the object
        ///</summary>
        public void Set_StyleName(string Name) 
		{
			this._i.StyleName = Name;
		}

        ///<summary>
        ///Specifies both the vertical and horizontal alignments for the attribute
        ///</summary>
        public object Alignment => this._i.Alignment;

        ///<summary>
        ///Specifies both the vertical and horizontal alignments for the attribute
        ///</summary>
        public void Set_Alignment(OdaX.AcAlignment align) 
		{
			this._i.Alignment = align;
		}

		///<summary>
		///
		///</summary>
		public object HorizontalAlignment => this._i.HorizontalAlignment;

		///<summary>
		///
		///</summary>
		public void Set_HorizontalAlignment(OdaX.AcHorizontalAlignment horizAlign) 
		{
			this._i.HorizontalAlignment = horizAlign;
		}

		///<summary>
		///
		///</summary>
		public object VerticalAlignment => this._i.VerticalAlignment;

		///<summary>
		///
		///</summary>
		public void Set_VerticalAlignment(OdaX.AcVerticalAlignment vertiAlign) 
		{
			this._i.VerticalAlignment = vertiAlign;
		}

        ///<summary>
        ///Changes the height of the object
        ///</summary>
        public double Height => this._i.Height;

        ///<summary>
        ///Changes the height of the object
        ///</summary>
        public void Set_Height(double Height) 
		{
			this._i.Height = Height;
		}

        ///<summary>
        ///Specifies the rotation angle for the object
        ///</summary>
        public double Rotation => this._i.Rotation;

        ///<summary>
        ///Specifies the rotation angle for the object
        ///</summary>
        public void Set_Rotation(dynamic rotAngle) 
		{
			this._i.Rotation = rotAngle;
		}

        ///<summary>
        ///Specifies the scale factor for the object
        ///</summary>
        public double ScaleFactor => this._i.ScaleFactor;

        ///<summary>
        ///Specifies the scale factor for the object
        ///</summary>
        public void Set_ScaleFactor(double scalFactor) 
		{
			this._i.ScaleFactor = scalFactor;
		}

        ///<summary>
        ///Specifies the oblique angle of the object
        ///</summary>
        public double ObliqueAngle => this._i.ObliqueAngle;

        ///<summary>
        ///Specifies the oblique angle of the object
        ///</summary>
        public void Set_ObliqueAngle(double obliAngle) 
		{
			this._i.ObliqueAngle = obliAngle;
		}

        ///<summary>
        ///Specifies the alignment point for text and attributes
        ///</summary>
        public Point TextAlignmentPoint => Technical.PointByDoubleArray(this._i.TextAlignmentPoint);

        ///<summary>
        ///Specifies the alignment point for text and attributes
        ///</summary>
        public void Set_TextAlignmentPoint(Point alignPoint) 
		{
			this._i.TextAlignmentPoint = Technical.PointByDynPoint(alignPoint);
		}

        ///<summary>
        ///Insertion point for a object
        ///</summary>
        public Point InsertionPoint => Technical.PointByDoubleArray(this._i.InsertionPoint);

        ///<summary>
        ///Insertion point for a object
        ///</summary>
        public void Set_InsertionPoint(Point insPoint) 
		{
			this._i.InsertionPoint = Technical.PointByDynPoint(insPoint);
		}

        ///<summary>
        /// Get the Normal vector from that object
        ///</summary>
        public Vector Normal => Technical.VectorByDoubleArray(this._i.Normal);

        ///<summary>
        /// Set Normal to that object by Dynamo vector
        ///</summary>
        public void Set_Normal(Vector Normal)
        {
            this._i.Normal = Technical.VectorByDynVector(Normal);
        }

        ///<summary>
        ///Specifies the attribute text generation flag
        ///</summary>
        public int TextGenerationFlag => this._i.TextGenerationFlag;

        ///<summary>
        ///Specifies the attribute text generation flag
        ///</summary>
        public void Set_TextGenerationFlag(int textGenFlag) 
		{
			this._i.TextGenerationFlag = textGenFlag;
		}

        ///<summary>
        ///Specifies the distance a 2D AutoCAD object is extruded above or below its elevation
        ///</summary>
        public double Thickness => this._i.Thickness;

        ///<summary>
        ///Specifies the distance a 2D AutoCAD object is extruded above or below its elevation
        ///</summary>
        public void Set_Thickness(double Thickness) 
		{
			this._i.Thickness = Thickness;
		}

        ///<summary>
        ///Specifies the mode of the attribute definition; acAttributeMode enum
        ///</summary>
        public int Mode => this._i.Mode;

        ///<summary>
        ///Specifies the mode of the attribute definition; acAttributeMode enum
        ///</summary>
        public void Set_Mode(int Mode) 
		{
			this._i.Mode = Mode;
		}

        ///<summary>
        ///Specifies the direction of text
        ///</summary>
        public bool UpsideDown => this._i.UpsideDown;

        ///<summary>
        ///Specifies the direction of text
        ///</summary>
        public void Set_UpsideDown(bool bUpsideDown) 
		{
			this._i.UpsideDown = bUpsideDown;
		}

        ///<summary>
        ///Specifies the direction of text
        ///</summary>
        public bool Backward => this._i.Backward;

        ///<summary>
        ///Specifies the direction of text
        ///</summary>
        public void Set_Backward(bool bBackward) 
		{
			this._i.Backward = bBackward;
		}

        ///<summary>
        ///Specifies whether the attribute or attribute reference is invisible
        ///</summary>
        public bool Invisible => this._i.Invisible;

        ///<summary>
        ///Specifies whether the attribute or attribute reference is invisible
        ///</summary>
        public void Set_Invisible(bool bInvisible) 
		{
			this._i.Invisible = bInvisible;
		}

        ///<summary>
        ///Specifies whether the attribute or attribute reference is constant or not
        ///</summary>
        public bool Constant => this._i.Constant;

        ///<summary>
        ///Specifies whether the attribute or attribute reference is constant or not
        ///</summary>
        public void Set_Constant(bool bConstant) 
		{
			this._i.Constant = bConstant;
		}

        ///<summary>
        ///Specifies if the attribute is set for verification
        ///</summary>
        public bool Verify => this._i.Verify;

        ///<summary>
        ///Specifies if the attribute is set for verification
        ///</summary>
        public void Set_Verify(bool bVerify) 
		{
			this._i.Verify = bVerify;
		}

        ///<summary>
        ///Specifies if the attribute is preset
        ///</summary>
        public bool Preset => this._i.Preset;

        ///<summary>
        ///Specifies if the attribute is preset
        ///</summary>
        public void Set_Preset(bool bPreset) 
		{
			this._i.Preset = bPreset;
		}

        ///<summary>
        ///Specifies whether the attribute or attribute reference may be moved relative to the geometry in the block
        ///</summary>
        public bool LockPosition => this._i.LockPosition;

        ///<summary>
        ///Specifies whether the attribute or attribute reference may be moved relative to the geometry in the block
        ///</summary>
        public void Set_LockPosition(bool bLockPosition) 
		{
			this._i.LockPosition = bLockPosition;
		}

        ///<summary>
        ///Determines if the attribute is multiline
        ///</summary>
        public bool MTextAttribute => this._i.MTextAttribute;

        ///<summary>
        ///Determines if the attribute is multiline
        ///</summary>
        public void Set_MTextAttribute(bool bMTextAttribute) 
		{
			this._i.MTextAttribute = bMTextAttribute;
		}

        ///<summary>
        ///Gets the multiline attribute content
        ///</summary>
        public string MTextAttributeContent => this._i.MTextAttributeContent;

        ///<summary>
        ///Gets the multiline attribute content
        ///</summary>
        public void Set_MTextAttributeContent(string content) 
		{
			this._i.MTextAttributeContent = content;
		}

        ///<summary>
        ///Updates attribute from the multiline text and multiline text from an attribute
        ///</summary>
        public void UpdateMTextAttribute() 
		{
			this._i.UpdateMTextAttribute();
		}

        ///<summary>
        ///Determines the width of the text boundary for the multiline attribute
        ///</summary>
        public double MTextBoundaryWidth => this._i.MTextBoundaryWidth;

        ///<summary>
        ///Determines the width of the text boundary for the multiline attribute
        ///</summary>
        public void Set_MTextBoundaryWidth(double MTextBoundaryWidth) 
		{
			this._i.MTextBoundaryWidth = MTextBoundaryWidth;
		}

        ///<summary>
        ///Determines the drawing direction for the multiline attribute
        ///</summary>
        public object MTextDrawingDirection => this._i.MTextDrawingDirection;

        ///<summary>
        ///Determines the drawing direction for the multiline attribute
        ///</summary>
        public void Set_MTextDrawingDirection(OdaX.AcDrawingDirection drawDir) 
		{
			this._i.MTextDrawingDirection = drawDir;
		}
	}
}
