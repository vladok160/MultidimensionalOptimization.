using System.Security.Cryptography;

namespace MultidimensionalOptimization_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GradientDescent_Click(object sender, EventArgs e)
        {
            GradientDescent gd = new GradientDescent(0.001);
            X1.Text = Convert.ToString(gd.MethodForX1());
            X2.Text = Convert.ToString(gd.MethodForX2());
            F.Text = Convert.ToString(gd.MethodForF());
            Iterations.Text = Convert.ToString(gd.GetCountOfIterations());
        }

        private void FastestGradient_Click(object sender, EventArgs e)
        {
            FastestGradient fastestGradient = new FastestGradient(0.001);
            X1.Text = Convert.ToString(fastestGradient.MethodForX1());
            X2.Text = Convert.ToString(fastestGradient.MethodForX2());
            F.Text = Convert.ToString(fastestGradient.MethodForF());
            Iterations.Text = Convert.ToString(fastestGradient.GetCountOfIterations());
        }

        private void DescentOfTheSecondOrder_Click(object sender, EventArgs e)
        {
            DescentOfTheSecondOrder DSO = new DescentOfTheSecondOrder(0.001);
            X1.Text = Convert.ToString(DSO.MethodForX1());
            X2.Text = Convert.ToString(DSO.MethodForX2());
            F.Text = Convert.ToString(DSO.MethodForF());
            Iterations.Text = Convert.ToString(DSO.GetCountOfIterations());
        }

        private void FletcherReevesMethod_Click(object sender, EventArgs e)
        {
            FletcherReevesMethod FR = new FletcherReevesMethod(0.001);
            X1.Text = Convert.ToString(FR.MethodForX1());
            X2.Text = Convert.ToString(FR.MethodForX2());
            F.Text = Convert.ToString(FR.MethodForF());
            Iterations.Text = Convert.ToString(FR.GetCountOfIterations());
        }

        private void ModifiedNewtonsMethod_Click(object sender, EventArgs e)
        {
            ModifiedNewtonsMethod Mode = new ModifiedNewtonsMethod(0.001);
            X1.Text = Convert.ToString(Mode.MethodForX1());
            X2.Text = Convert.ToString(Mode.MethodForX2());
            F.Text = Convert.ToString(Mode.MethodForF());
            Iterations.Text = Convert.ToString(Mode.GetCountOfIterations());
        }
    }
}