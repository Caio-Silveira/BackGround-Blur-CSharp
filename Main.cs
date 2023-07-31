namespace Example
{
    public partial class Main : Form
    {
        public Main()
        {
        InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Blur.SetBlur(this.Handle);
        }
    }
}
