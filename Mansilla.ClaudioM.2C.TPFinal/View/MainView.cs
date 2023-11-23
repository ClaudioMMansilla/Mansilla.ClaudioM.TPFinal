using Entidades.Archivos;
using Entidades.Enum;
using Entidades.MetodosExtencion;
using Entidades.Modelos;

namespace View
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void btnPacienteABM_Click(object sender, EventArgs e)
        {
            ViewPaciente viewPaciente = new ViewPaciente();
            viewPaciente.ShowDialog();
        }


        private void btnAdmGuardia_Click(object sender, EventArgs e)
        {
            ViewAdmisionGuardia viewGuardia = new ViewAdmisionGuardia();
            viewGuardia.ShowDialog();
        }

        private void btnAtencionGuardia_Click(object sender, EventArgs e)
        {
            ViewGuardia viewAtencionGuardia = new ViewGuardia();
            viewAtencionGuardia.ShowDialog();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese n° DNI del paciente: ", "Exportar historial", "0", 100, 50);
            paciente = paciente.BuscarPacienteDB(input);

            if (paciente.Dni > 0)
            {
                FileManager<Paciente>.ExportarArchivo(paciente);
                MessageBox.Show($"Se ha exportado en: {FileManager<Paciente>.GetPathExport()}", "Proceso realizado", MessageBoxButtons.OK);
            }
            else { MessageBox.Show("El dni ingresado es inválido", "Validación de dni incorrecta", MessageBoxButtons.OK); }
        }
    }
}