using System.Web.Services;


[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService]
public class CalcWebService : WebService
{

    [WebMethod]
    public int Somar(int x, int y)
    {
        return x + y;
    }

}
