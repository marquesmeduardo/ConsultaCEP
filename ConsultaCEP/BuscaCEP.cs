namespace ConsultaCEP {
    using System.Net;
    using System.Web;
    using WebServiceCEP;
    public class BuscaCEP {
        
        public enderecoERP ConsultaCEP(string cep) {
            bool isLocal = HttpContext.Current.Request.IsLocal;
            if (isLocal) {
                WebProxy p = new WebProxy("http://192.168.100.1:8080", true);
                GlobalProxySelection.Select = p;
            }

            enderecoERP resposta = new enderecoERP();
            using (var ws = new AtendeClienteClient()) {
                resposta = ws.consultaCEP(cep);
            }
            return resposta;
        }
    }
}
