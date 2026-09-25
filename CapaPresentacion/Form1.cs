using CapaAccesoDatos;
using CapaAccesoDatosMongo;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {

        LogicaNegocio logica = new LogicaNegocio(new ConexionMongo());
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            string placa = tbPlacaIngreso.Text;
            string tipoVehiculo = cbTipoVehiculoIngreso.Text;

            if (placa.Replace(" ", "") == "")
            {
                MessageBox.Show(this, "La placa está vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tipoVehiculo.Replace(" ", "") == "")
            {
                MessageBox.Show(this, "El tipo de vehículo está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool ingresoExitoso = logica.ingresarVehiculo(placa, tipoVehiculo);

            if (ingresoExitoso)
            {
                MessageBox.Show(this, "Vehículo ingresado correctamente", "Ingreso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPlacaIngreso.Text = "";
                cbTipoVehiculoIngreso.Text = "";
            }
            else
            {
                MessageBox.Show(this, "Error al ingresar. Intente e nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            string placa = tbPlacaSalida.Text;
            if (placa.Replace(" ", "") == "")
            {
                MessageBox.Show(this, "La placa está vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int valorAPagar = logica.consultarValorAPagar(placa);

            DialogResult resultado = MessageBox.Show(this,
                "El valor a pagar es $" + valorAPagar + "\n¿El usuario ya hizo el pago?",
                "Confirmación de pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                logica.darSalida(placa);
                MessageBox.Show(this, "El vehiculo ha salido correctamente", "Salida exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPlacaSalida.Text = "";
            }
        }
    }
}
