namespace Conversor_de_Medidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbTipo.DataSource = Enum.GetValues(typeof(tipoEnumerador));
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;

            lstDesde.DataSource = Enum.GetValues(typeof(tiempoEnumerador));
            lstA.DataSource = Enum.GetValues(typeof(tiempoEnumerador));
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // otra opcion --> var indiceSeleccionado = cmbTipo.SelectedIndex;
            var seleccionado = (tipoEnumerador) cmbTipo.SelectedItem;

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
    }
}