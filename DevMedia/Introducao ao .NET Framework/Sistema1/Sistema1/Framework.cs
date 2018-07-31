using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema1
{
    public enum TipoEnvio { EMAIL = 0, SMS = 1, WHATSAPP = 2}

    public abstract class FormaEnvio
    {
        public abstract void Enviar(string aviso);
    }

    public class Email : FormaEnvio
    {
        public override void Enviar(string aviso) {
            MessageBox.Show("Email enviado: " + aviso);
        }
    }

    public class SMS : FormaEnvio
    {
        public override void Enviar(string aviso)
        {
            MessageBox.Show("SMS enviado: " + aviso);
        }
    }

    public class WhatsApp : FormaEnvio
    {
        public override void Enviar(string aviso)
        {
            MessageBox.Show("WhatsApp enviado: " + aviso);
        }
    }

    public class Fabrica
    {
        public static FormaEnvio CriarEnvio(TipoEnvio tipo)
        {
            switch (tipo)
            {
                case TipoEnvio.SMS:
                    return new SMS();
                    break;
                case TipoEnvio.EMAIL:
                    return new Email();
                    break;
                case TipoEnvio.WHATSAPP:
                    return new WhatsApp();
                    break;
                default:
                    return null;
                    break;
            }
        }
    }
}
