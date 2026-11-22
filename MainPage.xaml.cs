namespace S8_P4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Lee y valida los dos campos; devuelve false si alguno no es un número válido
        private bool LeerNumeros(out double numero1, out double numero2)
        {
            numero1 = 0;
            numero2 = 0;
            return double.TryParse(txtNumero1.Text, out numero1) &&
                   double.TryParse(txtNumero2.Text, out numero2);
        }

        private void Sumar_Clicked(object sender, EventArgs e)
        {
            if (LeerNumeros(out double numero1, out double numero2))
            {
                double resultado = numero1 + numero2;
                lblResultado.Text = $"Resultado: {resultado}";
            }
            else
            {
                lblResultado.Text = "Por favor, ingresa números válidos.";
            }
        }

        // Reto 1
        private void Restar_Clicked(object sender, EventArgs e)
        {
            if (LeerNumeros(out double numero1, out double numero2))
            {
                lblResultado.Text = $"Resultado: {numero1 - numero2}";
            }
            else
            {
                lblResultado.Text = "Por favor, ingresa números válidos.";
            }
        }

        // Reto 3
        private void Multiplicar_Clicked(object sender, EventArgs e)
        {
            if (LeerNumeros(out double numero1, out double numero2))
            {
                lblResultado.Text = $"Resultado: {numero1 * numero2}";
            }
            else
            {
                lblResultado.Text = "Por favor, ingresa números válidos.";
            }
        }

        // Reto 3 (con validación de división entre cero)
        private void Dividir_Clicked(object sender, EventArgs e)
        {
            if (LeerNumeros(out double numero1, out double numero2))
            {
                if (numero2 == 0)
                    lblResultado.Text = "No se puede dividir entre cero.";
                else
                    lblResultado.Text = $"Resultado: {numero1 / numero2}";
            }
            else
            {
                lblResultado.Text = "Por favor, ingresa números válidos.";
            }
        }
    }
}
