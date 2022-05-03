using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_LetterENTBase
/// </summary>
public class MST_LetterENTBase
{
    #region Properties

    protected SqlInt32 _LetterID;
    public SqlInt32 LetterID
    {
        get
        {
            return _LetterID;
        }
        set
        {
            _LetterID = value;
        }
    }

    protected SqlString _LetterName;
    public SqlString LetterName
    {
        get
        {
            return _LetterName;
        }
        set
        {
            _LetterName = value;
        }
    }

    protected SqlString _LetterURL;
    public SqlString LetterURL
    {
        get
        {
            return _LetterURL;
        }
        set
        {
            _LetterURL = value;
        }
    }

    protected SqlString _Image;
    public SqlString Image
    {
        get
        {
            return _Image;
        }
        set
        {
            _Image = value;
        }
    }
    

    protected SqlBoolean _IsActive;
    public SqlBoolean IsActive
    {
        get
        {
            return _IsActive;
        }
        set
        {
            _IsActive = value;
        }
    }

    protected SqlDecimal _Sequence;
    public SqlDecimal Sequence
    {
        get
        {
            return _Sequence;
        }
        set
        {
            _Sequence = value;
        }
    }

    protected SqlDateTime _Created;
    public SqlDateTime Created
    {
        get
        {
            return _Created;
        }
        set
        {
            _Created = value;
        }
    }

    protected SqlDateTime _Modified;
    public SqlDateTime Modified
    {
        get
        {
            return _Modified;
        }
        set
        {
            _Modified = value;
        }
    }

    #endregion Properties

    #region Constructor
    public MST_LetterENTBase()
	{
		//
		// TODO: Add constructor logic here
		//
    }
    #endregion

    #region ToString

    public override String ToString()
    {
        String MST_LetterENT_String = String.Empty;

        if (!LetterID.IsNull)
            MST_LetterENT_String += " LetterID = " + LetterID.Value.ToString();

        if (!LetterName.IsNull)
            MST_LetterENT_String += "| LetterName = " + LetterName.Value;

        if (!LetterURL.IsNull)
            MST_LetterENT_String += "| LetterURL = " + LetterURL.Value;

        if (!Image.IsNull)
            MST_LetterENT_String += "| Image = " + Image.Value;

        if (!IsActive.IsNull)
            MST_LetterENT_String += "| IsActive = " + IsActive.Value;

        if (!Sequence.IsNull)
            MST_LetterENT_String += "| Sequence = " + Sequence.Value.ToString();

        if (!Created.IsNull)
            MST_LetterENT_String += "| Created = " + Created.Value.ToString("dd-MM-yyyy");

        if (!Modified.IsNull)
            MST_LetterENT_String += "| Modified = " + Modified.Value.ToString("dd-MM-yyyy");


        MST_LetterENT_String = MST_LetterENT_String.Trim();

        return MST_LetterENT_String;
    }

    #endregion ToString
}