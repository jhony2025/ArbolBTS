using System;
using System.Windows.Forms;
using System.Drawing;

class Program
{
    static ArbolBST arbol = new ArbolBST();

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new FormularioBST());
    }
}

class FormularioBST : Form
{
    private TextBox txtValor;
    private Button btnInsertar, btnBuscar, btnEliminar, btnInorden, btnPreorden, btnPostorden, btnMinimo, btnMaximo, btnAltura, btnLimpiar;
    private Label lblResultado;
    private PictureBox pictureBox;
    private ArbolBST arbol = new ArbolBST();

    public FormularioBST()
    {
        this.Text = "Arbol Binario BST";
        this.Size = new System.Drawing.Size(600, 600);

        txtValor = new TextBox();
        txtValor.Location = new System.Drawing.Point(10, 10);
        txtValor.Width = 100;

        btnInsertar = new Button();
        btnInsertar.Text = "Insertar";
        btnInsertar.Location = new System.Drawing.Point(10, 40);
        btnInsertar.Click += BtnInsertar_Click;

        btnBuscar = new Button();
        btnBuscar.Text = "Buscar";
        btnBuscar.Location = new System.Drawing.Point(120, 40);
        btnBuscar.Click += BtnBuscar_Click;

        btnEliminar = new Button();
        btnEliminar.Text = "Eliminar";
        btnEliminar.Location = new System.Drawing.Point(230, 40);
        btnEliminar.Click += BtnEliminar_Click;

        btnInorden = new Button();
        btnInorden.Text = "Inorden";
        btnInorden.Location = new System.Drawing.Point(10, 80);
        btnInorden.Click += BtnInorden_Click;

        btnPreorden = new Button();
        btnPreorden.Text = "Preorden";
        btnPreorden.Location = new System.Drawing.Point(120, 80);
        btnPreorden.Click += BtnPreorden_Click;

        btnPostorden = new Button();
        btnPostorden.Text = "Postorden";
        btnPostorden.Location = new System.Drawing.Point(230, 80);
        btnPostorden.Click += BtnPostorden_Click;

        btnMinimo = new Button();
        btnMinimo.Text = "Minimo";
        btnMinimo.Location = new System.Drawing.Point(10, 120);
        btnMinimo.Click += BtnMinimo_Click;

        btnMaximo = new Button();
        btnMaximo.Text = "Maximo";
        btnMaximo.Location = new System.Drawing.Point(120, 120);
        btnMaximo.Click += BtnMaximo_Click;

        btnAltura = new Button();
        btnAltura.Text = "Altura";
        btnAltura.Location = new System.Drawing.Point(230, 120);
        btnAltura.Click += BtnAltura_Click;

        btnLimpiar = new Button();
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.Location = new System.Drawing.Point(10, 160);
        btnLimpiar.Click += BtnLimpiar_Click;

        lblResultado = new Label();
        lblResultado.Location = new System.Drawing.Point(10, 200);
        lblResultado.Width = 350;
        lblResultado.Height = 50;

        pictureBox = new PictureBox();
        pictureBox.Location = new System.Drawing.Point(10, 260);
        pictureBox.Size = new System.Drawing.Size(550, 300);
        pictureBox.BackColor = Color.White;
        pictureBox.Paint += PictureBox_Paint;

        this.Controls.Add(txtValor);
        this.Controls.Add(btnInsertar);
        this.Controls.Add(btnBuscar);
        this.Controls.Add(btnEliminar);
        this.Controls.Add(btnInorden);
        this.Controls.Add(btnPreorden);
        this.Controls.Add(btnPostorden);
        this.Controls.Add(btnMinimo);
        this.Controls.Add(btnMaximo);
        this.Controls.Add(btnAltura);
        this.Controls.Add(btnLimpiar);
        this.Controls.Add(lblResultado);
        this.Controls.Add(pictureBox);
    }

    private void BtnInsertar_Click(object sender, EventArgs e)
    {
        try
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                arbol.Raiz = arbol.Insertar(arbol.Raiz, valor);
                lblResultado.Text = $"Insertado: {valor}";
                pictureBox.Refresh();
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al insertar: " + ex.Message);
        }
    }

    private void BtnBuscar_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtValor.Text, out int valor))
        {
            bool encontrado = arbol.Buscar(arbol.Raiz, valor);
            lblResultado.Text = encontrado ? "Encontrado" : "No encontrado";
        }
        else
        {
            MessageBox.Show("Ingrese un numero valido");
        }
    }

    private void BtnEliminar_Click(object sender, EventArgs e)
    {
        try
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                arbol.Raiz = arbol.Eliminar(arbol.Raiz, valor);
                lblResultado.Text = $"Eliminado: {valor}";
                pictureBox.Refresh();
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al eliminar: " + ex.Message);
        }
    }

    private void BtnInorden_Click(object sender, EventArgs e)
    {
        string resultado = "";
        Inorden(arbol.Raiz, ref resultado);
        lblResultado.Text = "Inorden: " + resultado;
    }

    private void BtnPreorden_Click(object sender, EventArgs e)
    {
        string resultado = "";
        Preorden(arbol.Raiz, ref resultado);
        lblResultado.Text = "Preorden: " + resultado;
    }

    private void BtnPostorden_Click(object sender, EventArgs e)
    {
        string resultado = "";
        Postorden(arbol.Raiz, ref resultado);
        lblResultado.Text = "Postorden: " + resultado;
    }

    private void BtnMinimo_Click(object sender, EventArgs e)
    {
        if (arbol.Raiz != null)
        {
            lblResultado.Text = "Minimo: " + arbol.Minimo(arbol.Raiz);
        }
        else
        {
            lblResultado.Text = "Arbol vacio";
        }
    }

    private void BtnMaximo_Click(object sender, EventArgs e)
    {
        if (arbol.Raiz != null)
        {
            lblResultado.Text = "Maximo: " + arbol.Maximo(arbol.Raiz);
        }
        else
        {
            lblResultado.Text = "Arbol vacio";
        }
    }

    private void BtnAltura_Click(object sender, EventArgs e)
    {
        lblResultado.Text = "Altura: " + arbol.Altura(arbol.Raiz);
    }

    private void BtnLimpiar_Click(object sender, EventArgs e)
    {
        try
        {
            arbol.Limpiar();
            lblResultado.Text = "Arbol limpiado";
            pictureBox.Refresh();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al limpiar: " + ex.Message);
        }
    }

    // Metodos auxiliares para recorridos sin Console
    private void Inorden(Nodo nodo, ref string resultado)
    {
        if (nodo != null)
        {
            Inorden(nodo.Izquierdo, ref resultado);
            resultado += nodo.Valor + " ";
            Inorden(nodo.Derecho, ref resultado);
        }
    }

    private void Preorden(Nodo nodo, ref string resultado)
    {
        if (nodo != null)
        {
            resultado += nodo.Valor + " ";
            Preorden(nodo.Izquierdo, ref resultado);
            Preorden(nodo.Derecho, ref resultado);
        }
    }

    private void Postorden(Nodo nodo, ref string resultado)
    {
        if (nodo != null)
        {
            Postorden(nodo.Izquierdo, ref resultado);
            Postorden(nodo.Derecho, ref resultado);
            resultado += nodo.Valor + " ";
        }
    }

    private void PictureBox_Paint(object sender, PaintEventArgs e)
    {
        try
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            if (arbol.Raiz != null)
            {
                DrawTree(g, arbol.Raiz, pictureBox.Width / 2, 30, pictureBox.Width / 4);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al dibujar: " + ex.Message);
        }
    }

    private void DrawTree(Graphics g, Nodo nodo, int x, int y, int offset)
    {
        if (nodo == null) return;

        // Draw node
        g.FillEllipse(Brushes.LightBlue, x - 15, y - 15, 30, 30);
        g.DrawEllipse(Pens.Black, x - 15, y - 15, 30, 30);
        g.DrawString(nodo.Valor.ToString(), this.Font, Brushes.Black, x - 10, y - 10);

        // Draw left child
        if (nodo.Izquierdo != null)
        {
            g.DrawLine(Pens.Black, x, y, x - offset, y + 50);
            DrawTree(g, nodo.Izquierdo, x - offset, y + 50, offset / 2);
        }

        // Draw right child
        if (nodo.Derecho != null)
        {
            g.DrawLine(Pens.Black, x, y, x + offset, y + 50);
            DrawTree(g, nodo.Derecho, x + offset, y + 50, offset / 2);
        }
    }
}
