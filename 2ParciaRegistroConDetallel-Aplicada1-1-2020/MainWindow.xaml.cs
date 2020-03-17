using _2ParciaRegistroConDetallel_Aplicada1_1_2020.BLL;
using _2ParciaRegistroConDetallel_Aplicada1_1_2020.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2ParciaRegistroConDetallel_Aplicada1_1_2020
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Llamadas llamadas = new Llamadas();

       
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = llamadas;
            LLamadasIdTex.Text = "0";
        }

        private void Limpiar()
        {
            LLamadasIdTex.Text = "0";
            DescripcionTex.Text = string.Empty;
            ProblemaTex.Text = string.Empty;
            SolucionTex.Text = string.Empty;
            llamadas = new Llamadas();
            llamadas.LlamadaDetalle = new List<LLamadasDetalle>();
           
            LLenar();

        }
       
        private void LLenar()
        {
            this.DataContext = null;
            this.DataContext = llamadas;
        }

        private bool ExisteEnLaBaseDeDAtosLLamadas()
        {
            Llamadas llamadass = LLamadasBLL.Buscar(llamadas.LlamadasId);
            return (llamadass != null);
        }
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Llamadas llamadasAnterio = LLamadasBLL.Buscar(llamadas.LlamadasId);

            Limpiar();
            if(llamadasAnterio != null)
            {
                llamadas = llamadasAnterio;
                LLenar();
            }
            else
            {
                Limpiar();
                MessageBox.Show("LLamada no Existe...");
            }

        }

        private void GuardaButton_Click(object sender, RoutedEventArgs e)
        {
            bool pase = false;

            if (llamadas.LlamadasId == 0)  
                pase = LLamadasBLL.Guardar(llamadas);
            else
            {
                if (!ExisteEnLaBaseDeDAtosLLamadas())
                {
                    MessageBox.Show("No se puede modificar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                pase = LLamadasBLL.Modificar(llamadas);
            }
            if (pase)
            {
                Limpiar();
                MessageBox.Show("Guardado", "Existo", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo");

        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (LLamadasBLL.Eliminar(llamadas.LlamadasId))
            {
                Limpiar();
                MessageBox.Show("Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Error al eliminar una llamada");
            }

        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            llamadas.LlamadaDetalle.Add(new LLamadasDetalle(llamadas.LlamadasId, ProblemaTex.Text, SolucionTex.Text));

            LLenar();   
            ProblemaTex.Clear();
            SolucionTex.Clear();
            ProblemaTex.Focus();

        }

        private void RemoverButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataGriDetalle.Columns.Count > 0 && DataGriDetalle.SelectedCells != null)
            {
                llamadas.LlamadaDetalle.RemoveAt(DataGriDetalle.SelectedIndex);
                LLenar();
            }

        }

       
    }
}
