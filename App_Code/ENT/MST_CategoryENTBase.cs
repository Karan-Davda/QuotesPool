using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_CategoryENTBase
/// </summary>
public class MST_CategoryENTBase
{
    #region Properties

    protected SqlInt32 _CategoryID;
    public SqlInt32 CategoryID
    {
        get
        {
            return _CategoryID;
        }
        set
        {
            _CategoryID = value;
        }
    }

    protected SqlString _CategoryName;
    public SqlString CategoryName
    {
        get
        {
            return _CategoryName;
        }
        set
        {
            _CategoryName = value;
        }
    }

    protected SqlString _CategoryIcon;
    public SqlString CategoryIcon
    {
        get
        {
            return _CategoryIcon;
        }
        set
        {
            _CategoryIcon = value;
        }
    }

    protected SqlString _CategoryURL;
    public SqlString CategoryURL
    {
        get
        {
            return _CategoryURL;
        }
        set
        {
            _CategoryURL = value;
        }
    }

    protected SqlString _CategoryDescription;
    public SqlString CategoryDescription
    {
        get
        {
            return _CategoryDescription;
        }
        set
        {
            _CategoryDescription = value;
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

    public MST_CategoryENTBase()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #endregion Constructor

    #region ToString

    public override String ToString()
    {
        String MST_CategoryENT_String = String.Empty;

        if (!CategoryID.IsNull)
            MST_CategoryENT_String += " CategoryID = " + CategoryID.Value.ToString();

        if (!CategoryName.IsNull)
            MST_CategoryENT_String += "| CategoryName = " + CategoryName.Value;

        if (!CategoryIcon.IsNull)
            MST_CategoryENT_String += "| CategoryIcon = " + CategoryIcon.Value;

        if (!CategoryURL.IsNull)
            MST_CategoryENT_String += "| CategoryURL = " + CategoryURL.Value;

        if (!CategoryDescription.IsNull)
            MST_CategoryENT_String += "| CategoryDescription = " + CategoryDescription.Value;

        if (!IsActive.IsNull)
            MST_CategoryENT_String += "| IsActive = " + IsActive.Value;

        if (!Sequence.IsNull)
            MST_CategoryENT_String += "| Sequence = " + Sequence.Value.ToString();

        if (!Created.IsNull)
            MST_CategoryENT_String += "| Created = " + Created.Value.ToString("dd-MM-yyyy");

        if (!Modified.IsNull)
            MST_CategoryENT_String += "| Modified = " + Modified.Value.ToString("dd-MM-yyyy");


        MST_CategoryENT_String = MST_CategoryENT_String.Trim();

        return MST_CategoryENT_String;
    }

    #endregion ToString
}