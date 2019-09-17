string RequestString(string mode, string fieldname)
{
    if (mode == "get")
    {
        try
        {
            return Request.QueryString[fieldname];
        }
        catch
        {
            return "";
        }
    }
    if (mode == "post")
    {
        try
        {
            return Request.Form[fieldname];
        }
        catch
        {
            return "";
        }
    }
    return "";
}
