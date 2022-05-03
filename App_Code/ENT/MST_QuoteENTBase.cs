using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_QuoteENTBase
/// </summary>
public class MST_QuoteENTBase
{
    #region Properties

    protected SqlInt32 _QuoteID;
    public SqlInt32 QuoteID
    {
        get
        {
            return _QuoteID;
        }
        set
        {
            _QuoteID = value;
        }
    }

    protected SqlString _Quote;
    public SqlString Quote
    {
        get
        {
            return _Quote;
        }
        set
        {
            _Quote = value;
        }
    }

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

    public MST_QuoteENTBase()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #endregion Constructor

    #region ToString

    public override String ToString()
    {
        String MST_QuoteENT_String = String.Empty;

        if (!QuoteID.IsNull)
            MST_QuoteENT_String += " QuoteID = " + QuoteID.Value.ToString();

        if (!Quote.IsNull)
            MST_QuoteENT_String += "| Quote = " + Quote.Value;

        if (!CategoryID.IsNull)
            MST_QuoteENT_String += "| CategoryID = " + CategoryID.Value.ToString();

        if (!AuthorID.IsNull)
            MST_QuoteENT_String += "| AuthorID = " + AuthorID.Value.ToString();

        if (!Image.IsNull)
            MST_QuoteENT_String += "| Image = " + Image.Value;

        if (!IsActive.IsNull)
            MST_QuoteENT_String += "| IsActive = " + IsActive.Value;

        if (!Sequence.IsNull)
            MST_QuoteENT_String += "| Sequence = " + Sequence.Value.ToString();

        if (!Created.IsNull)
            MST_QuoteENT_String += "| Created = " + Created.Value.ToString("dd-MM-yyyy");

        if (!Modified.IsNull)
            MST_QuoteENT_String += "| Modified = " + Modified.Value.ToString("dd-MM-yyyy");


        MST_QuoteENT_String = MST_QuoteENT_String.Trim();

        return MST_QuoteENT_String;
    }

    #endregion ToString
}