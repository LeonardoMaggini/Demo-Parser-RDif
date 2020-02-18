using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///agrego una referencia al espacio de nombres de LgServerAPI
using LgServerAPI.DeferredRecharge;
using LgServerAPI;

namespace Demo_Parser_RDif
    {
    public partial class Form1 : Form
        {

        /// <summary>
        /// instancio un objeto de la clase DeferredRecharge
        /// </summary>
        DeferredRecharge Rdif = new DeferredRecharge();
        
        public Form1()
            {
            InitializeComponent();
            }


        private void buttonParse_Click(object sender, EventArgs e)
            {
            string tipoTrx = "";

            try
                {
                ///1. identifico el tipo de mensaje a parsear
                ///y lo almaceno en tipoTrx
                tipoTrx = textBox_Input.Text.Substring(0, 2);

                ///2. en funcion del tipo de mensaje, 
                ///parseo y muestro en pantalla
                switch (tipoTrx)
                    {
                    ///caso Requerimiento 0x72
                    case "72":
                        ///utilizo la clase Utilities del Namespace LgServerAPI, para obtener
                        ///el metodo GetBytesBigEndian() que me permite convertir a byte[]
                        ///un string.
                        ///Luego ejecuto el metodo GetRequestMessage() pasando como parametros
                        ///el array de bytes y la referencia al metodo .parse() de la clase DataRequest_0x72
                        Rdif.GetRequestMessage(Utilities.GetBytesBigEndian(textBox_Input.Text), Rdif.DataRequest_0x72.parse);
                        
                    ///finalmente lo muestro en pantalla...
                        textBox_Result.Clear();

                        textBox_Result.AppendText("Tipo Trx: " + Utilities.ToString(Rdif.Tipo_TRX) + "\n");
                        textBox_Result.AppendText("Version: " + Utilities.ToString(Rdif.Version) + "\n");
                        textBox_Result.AppendText("LEN: " + Utilities.ToString(Rdif.LEN_DATA) + "\n");
                        textBox_Result.AppendText("Id Red: " + Utilities.ToString(Rdif.DataRequest_0x72.ID_RED) + "\n");
                        textBox_Result.AppendText("POS Id: " + Utilities.ToString(Rdif.DataRequest_0x72.POS_ID) + "\n");
                        textBox_Result.AppendText("DataLG: " + Utilities.ToString(Rdif.DataRequest_0x72.DataLG) + "\n");
                        break;

                    ///caso Respuesta Exitosa Requerimiento (0x0090)
                    case "00":
                        ///utilizo la clase Utilities del Namespace LgServerAPI, para obtener
                        ///el metodo GetBytesBigEndian() que me permite convertir a byte[]
                        ///un string.
                        ///Luego ejecuto el metodo GetRequestMessage() pasando como parametros
                        ///el array de bytes y la referencia al metodo .parse() de la clase DataRequestResponse_0x72
                        Rdif.GetRequestMessageResponse(Utilities.GetBytesBigEndian(textBox_Input.Text), Rdif.DataRequestResponse_0x72.parse);

                        ///finalmente lo muestro en pantalla...
                        textBox_Result.Clear();

                        textBox_Result.AppendText("Cod.Respuesta: " + Utilities.ToString(Rdif.CodRespuesta) + "\n");
                        textBox_Result.AppendText("LEN: " + Utilities.ToString(Rdif.LEN_DATA) + "\n");
                        textBox_Result.AppendText("Id Transaccion: " + Utilities.ToString(Rdif.DataRequestResponse_0x72.TX_ID) + "\n");
                        textBox_Result.AppendText("Monto: " + Utilities.ToString(Rdif.DataRequestResponse_0x72.Monto) + "\n");
                        textBox_Result.AppendText("Otorgante: " + Utilities.ToString(Rdif.DataRequestResponse_0x72.Otorgante) + "\n");
                        textBox_Result.AppendText("Concepto: " + Utilities.ToString(Rdif.DataRequestResponse_0x72.Concepto) + "\n");
                        textBox_Result.AppendText("Monto Carga pendiente: " + Utilities.ToString(Rdif.DataRequestResponse_0x72.MontoPendiente) + "\n");
                        textBox_Result.AppendText("Criptograma: " + Utilities.ToString(Rdif.DataRequestResponse_0x72.Crypto_Data) + "\n");
                        textBox_Result.AppendText("Padding: " + Utilities.ToString(Rdif.DataRequestResponse_0x72.Padding) + "\n");
                        break;

                    ///caso Requerimiento Confirmacion 0x80
                    case "80":
                        ///utilizo la clase Utilities del Namespace LgServerAPI, para obtener
                        ///el metodo GetBytesBigEndian() que me permite convertir a byte[]
                        ///un string.
                        ///Luego ejecuto el metodo GetRequestMessage() pasando como parametros
                        ///el array de bytes y la referencia al metodo .parse() de la clase DataRequest_0x80
                        Rdif.GetRequestMessage(Utilities.GetBytesBigEndian(textBox_Input.Text), Rdif.DataRequest_0x80.parse);

                        ///finalmente lo muestro en pantalla...
                        textBox_Result.Clear();

                        textBox_Result.AppendText("Tipo Trx: " + Utilities.ToString(Rdif.Tipo_TRX) + "\n");
                        textBox_Result.AppendText("Version: " + Utilities.ToString(Rdif.Version) + "\n");
                        textBox_Result.AppendText("LEN: " + Utilities.ToString(Rdif.LEN_DATA) + "\n");
                        textBox_Result.AppendText("Id Transaccion: " + Utilities.ToString(Rdif.DataRequest_0x80.TX_ID) + "\n");
                        textBox_Result.AppendText("Saldo Purse: " + Utilities.ToString(Rdif.DataRequest_0x80.SaldoPurse) + "\n");
                        textBox_Result.AppendText("Importe Cargado: " + Utilities.ToString(Rdif.DataRequest_0x80.ImporteCargado) + "\n");
                        textBox_Result.AppendText("DataLG: " + Utilities.ToString(Rdif.DataRequest_0x80.DataLG) + "\n");
                        textBox_Result.AppendText("Padding: " + Utilities.ToString(Rdif.DataRequest_0x80.Padding) + "\n");
                        break;

                    ///Caso Requerimiento Reversa 0xFA
                    case "FA":
                        /// implementar...
                        break;
                     }
                }
            catch (Exception ex)
                {

                MessageBox.Show(ex.Message);
                }
            }

        
        }
    }
