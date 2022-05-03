using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_AuthorENTBase
/// </summary>
public class MST_AuthorENTBase
{
    #region Properties

    protected SqlInt32 _AuthorID;
    public SqlInt32 AuthorID
    {
        get
        {
            return _AuthorID;
        }
        set
        {
            _AuthorID = value;
        }
    }

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

    protected SqlString _AuthorName;
    public SqlString AuthorName
    {
        get
        {
            return _AuthorName;
        }
        set
        {
            _AuthorName = value;
        }
    }

    protected SqlString _NickName;
    public SqlString NickName
    {
        get
        {
            return _NickName;
        }
        set
        {
            _NickName = value;
        }
    }

    protected SqlString _AuthorURL;
    public SqlString AuthorURL
    {
        get
        {
            return _AuthorURL;
        }
        set
        {
            _AuthorURL = value;
        }
    }

    protected SqlString _AuthorDOB;
    public SqlString AuthorDOB
    {
        get
        {
            return _AuthorDOB;
        }
        set
        {
            _AuthorDOB = value;
        }
    }

    protected SqlString _AuthorDead;
    public SqlString AuthorDead
    {
        get
        {
            return _AuthorDead;
        }
        set
        {
            _AuthorDead = value;
        }
    }

    protected SqlString _Birthplace;
    public SqlString Birthplace
    {
        get
        {
            return _Birthplace;
        }
        set
        {
            _Birthplace = value;
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

    protected SqlString _Remarks;
    public SqlString Remarks
    {
        get
        {
            return _Remarks;
        }
        set
        {
            _Remarks = value;
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

    protected SqlString _Occupation;
    public SqlString Occupation
    {
        get
        {
            return _Occupation;
        }
        set
        {
            _Occupation = value;
        }
    }

    protected SqlString _WikiURL;
    public SqlString WikiURL
    {
        get
        {
            return _WikiURL;
        }
        set
        {
            _WikiURL = value;
        }
    }

    #endregion Properties

    #region Constructor

    public MST_AuthorENTBase()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #endregion Constructor

    #region ToString

    public override String ToString()
    {
        String MST_AuthorENT_String = String.Empty;

        if (!AuthorID.IsNull)
            MST_AuthorENT_String += " AuthorID = " + AuthorID.Value.ToString();

        if (!LetterID.IsNull)
            MST_AuthorENT_String += " | LetterID = " + LetterID.Value.ToString();

        if (!AuthorName.IsNull)
            MST_AuthorENT_String += "| AuthorName = " + AuthorName.Value;

        if (!NickName.IsNull)
            MST_AuthorENT_String += "| NickName = " + NickName.Value;

        if (!AuthorURL.IsNull)
            MST_AuthorENT_String += "| AuthorURL = " + AuthorURL.Value;

        if (!AuthorDOB.IsNull)
            MST_AuthorENT_String += "| AuthorDOB = " + AuthorDOB.Value;

        if (!AuthorDead.IsNull)
            MST_AuthorENT_String += "| AuthorDead = " + AuthorDead.Value;

        if (!Birthplace.IsNull)
            MST_AuthorENT_String += "| Birthplace = " + Birthplace.Value;

        if (!Image.IsNull)
            MST_AuthorENT_String += "| Image = " + Image.Value;

        if (!IsActive.IsNull)
            MST_AuthorENT_String += "| IsActive = " + IsActive.Value;

        if (!Sequence.IsNull)
            MST_AuthorENT_String += "| Sequence = " + Sequence.Value.ToString();

        if (!Created.IsNull)
            MST_AuthorENT_String += "| Created = " + Created.Value.ToString("dd-MM-yyyy");

        if (!Modified.IsNull)
            MST_AuthorENT_String += "| Modified = " + Modified.Value.ToString("dd-MM-yyyy");

        if (!Occupation.IsNull)
            MST_AuthorENT_String += "| Occupation = " + Occupation.Value;

        if (!WikiURL.IsNull)
            MST_AuthorENT_String += "| WikiURL = " + WikiURL.Value;

        MST_AuthorENT_String = MST_AuthorENT_String.Trim();

        return MST_AuthorENT_String;
    }

    #endregion ToString
}