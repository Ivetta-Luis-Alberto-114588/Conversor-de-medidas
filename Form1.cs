namespace Conversor_de_Medidas
{
    public partial class Form1 : Form
    {
        private ServicioConversion _servicio;
        public Form1()
        {
            InitializeComponent();
            _servicio = new ServicioConversion();

            cmbTipo.DataSource = Enum.GetValues(typeof(tipoEnumerador));
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;

            lstDesde.DataSource = Enum.GetValues(typeof(tiempoEnumerador));
            lstA.DataSource = Enum.GetValues(typeof(tiempoEnumerador));
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // otra opcion --> var indiceSeleccionado = cmbTipo.SelectedIndex;
            var seleccionado = (tipoEnumerador)cmbTipo.SelectedItem;

            if (seleccionado == tipoEnumerador.tiempo)
            {
                lstDesde.DataSource = Enum.GetValues(typeof(tiempoEnumerador));
                lstA.DataSource = Enum.GetValues(typeof(tiempoEnumerador));
            }
            else if (seleccionado == tipoEnumerador.masa)
            {
                lstDesde.DataSource = Enum.GetValues(typeof(masaEnumerador));
                lstA.DataSource = Enum.GetValues(typeof(masaEnumerador));
            }
            else if (seleccionado == tipoEnumerador.temperatura)
            {
                lstDesde.DataSource = Enum.GetValues(typeof(temperaturaEnumerador));
                lstA.DataSource = Enum.GetValues(typeof(temperaturaEnumerador));
            }


        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            var cantidadSeleccionada = txtIngreso.Text;
            var seleccionado = (tipoEnumerador)cmbTipo.SelectedItem;
            var desde = (tiempoEnumerador)lstDesde.SelectedItem;
            var a = (tiempoEnumerador)lstA.SelectedItem;

            //validaciones
            if (!double.TryParse(cantidadSeleccionada, out double cantidad))
            {
                MessageBox.Show("Ingrese un valor numerico");
                return;
            }


            if (cantidadSeleccionada.Length == 0)
            {
                return;

            }

            if (lstDesde.SelectedItem.Equals(lstA.SelectedItem))
            {
                lblConversion.Text = txtIngreso.Text.ToString();
                return;
            }


            //conversiones
            if (seleccionado == tipoEnumerador.tiempo)
            {
                var resultado = _servicio.ConvertirTiempo(Convert.ToDouble(cantidadSeleccionada), desde, a);
                lblConversion.Text = resultado.ToString() + " " + lstA.SelectedItem;
            }
            else if (seleccionado == tipoEnumerador.masa)
            {
                var resultado = _servicio.ConvertirMasa(Convert.ToDouble(cantidadSeleccionada), (masaEnumerador)lstDesde.SelectedItem, (masaEnumerador)lstA.SelectedItem);
                lblConversion.Text = resultado.ToString() + " " + lstA.SelectedItem;
            }
            else if (seleccionado == tipoEnumerador.temperatura)
            {
                var resultado = _servicio.ConvertirTemperatura(Convert.ToDouble(cantidadSeleccionada), (temperaturaEnumerador)lstDesde.SelectedItem, (temperaturaEnumerador)lstA.SelectedItem);
                lblConversion.Text = resultado.ToString() + " " + lstA.SelectedItem;
            }

            txtIngreso.Text = String.Empty;


        }
    }
}