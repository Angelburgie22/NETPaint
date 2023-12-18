using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETPaint
{
    public partial class Form1 : Form
    {
        //Atributos
        Bitmap bm; //creación de mapa de bits para utilizar como pizarra
        Graphics g; //superificie de dibujo
        Point px, py; //coordenadas para el movimiento del cursor
        Pen pencil; //lápiz para dibujo
        Pen eraser; //lápiz que actúa como borrador
        Color selectedColor; //variable para guardar el color seleccionado
        ColorDialog cd; //cuadro de diálogo de selección de color
        bool drawingAvailable; //bandera para definir si dibujar en la pizarra o no
        int currentAction; //guarda el índice de la acción a realizar
        int x, y, sX, sY, cX, cY; //variables para cálculo de posición
        int totalDelta; //variable para guardar la cantidad de veces que se ha movido la rueda del ratón según la dirección

        public Form1()
        {
            InitializeComponent();

            //Inicialización de atributos
            IniatilizeSettings();
        }

        private void IniatilizeSettings()
        {
            //Definición del bitmap con el área del picCanvas (pictureBox)
            bm = new Bitmap(picCanvas.Width, picCanvas.Height);
            //Definición del objeto Graphics especificando la imagen como el objeto bm
            g = Graphics.FromImage(bm);
            //Limpia la superificie y lo rellena con el color blanco
            g.Clear(Color.White);
            //Se asigna la imagen del picCanvas como el mapa de bits bm
            picCanvas.Image = bm;
            //Se define el objeto pencil con el color negro, y la anchura 1
            pencil = new Pen(Color.Black, 1);
            //Se define el objeto eraser con el color blanco, y la anchura 5   
            eraser = new Pen(Color.White, 5);
            //Se define el color seleccionado como el color negro (por defecto)
            selectedColor = Color.Black;
            //Se define la acción inicial como "dibujo"
            currentAction = 1;
            //Instancia de un control ColorDialog
            cd = new ColorDialog();
            //Se define totalDelta (para la anchura del lápiz) como 1
            totalDelta = 1;
            //Se cambia el color de fondo de picSelectedColor al color negro
            picSelectedColor.BackColor = selectedColor;
        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            //Cambia la acción a "dibujo"
            currentAction = 1;
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            //Cambia la acción a "borrar"
            currentAction = 2;
        }

        //Permite visualizar la forma en que se dibujan las figuras cada vez que se mueve el ratón, y el control es redibujado
        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            //Se instancia el espacio de dibujo del objeto picCanvas
            Graphics g = e.Graphics;

            if(drawingAvailable == true)
            {
                //Si la acción es 3, se dibuja una elípse
                if (currentAction == 3)
                {
                    g.DrawEllipse(pencil, cX, cY, sX, sY);
                }
                //Si la acción es 4, se dibuja un rectángulo
                else if (currentAction == 4)
                {
                    g.DrawRectangle(pencil, cX, cY, sX, sY);
                }
                //Si la acción es 5, se dibuja una línea
                else if (currentAction == 5)
                {
                    g.DrawLine(pencil, cX, cY, x, y);
                }
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            //Se muestra el selector de colores
            cd.ShowDialog();
            //Se guarda el color seleccionado en selectedColor
            selectedColor = cd.Color;
            //Se asigna el color seleccionado como el color de fondo de picSelectedColor
            picSelectedColor.BackColor = selectedColor;
            //Se asigna el color seleccionado como el color del lápiz de dibujo
            pencil.Color = selectedColor;
        }

        private void Validate(Bitmap bm, Stack<Point> sp, int x, int y, Color oldColor, Color newColor)
        {
            //Se obtiene el color del punto seleccionado por el ratón
            Color cx = bm.GetPixel(x, y);

            //Si el color seleccionado es igual al color antiguo que se ha de rellenar
            if(cx == oldColor)
            {
                //Se guarda el punto seleccionado en el stack de puntos a rellenar
                sp.Push(new Point(x, y));
                //Se cambia el color del punto seleccionado al color de relleno
                bm.SetPixel(x, y, newColor);
            }
        }

        private void Fill(Bitmap bm, int x, int y, Color newColor)
        {
            //Obtiene el color del punto seleccionado
            Color oldColor = bm.GetPixel(x, y);

            //Comprueba que el color de relleno y del punto seleccionado sean iguales para detener el método
            if (oldColor.ToArgb() == newColor.ToArgb()) return;
            
            //Se crea un stack de puntos a rellenar
            Stack<Point> pixels = new Stack<Point>();
            //Se guarda el punto seleccionado en el stack
            pixels.Push(new Point(x, y));
            //Se cambia el color del punto seleccionado por el color de relleno
            bm.SetPixel(x, y, newColor);

            //Se validan los puntos vecinos de los puntos en el stack, mientras este tenga puntos
            while(pixels.Count > 0)
            {
                //Se elimina el último punto, pues esta ya ha sido modificado
                Point pt = pixels.Pop();

                //Se comprueba que el punto tenga espacio en la pizarra para sus vecinos
                if(pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    //Se validan sus puntos vecinos en las direcciones: izquierda, arriba, derecha, abajo
                    Validate(bm, pixels, pt.X - 1, pt.Y, oldColor, newColor);
                    Validate(bm, pixels, pt.X, pt.Y - 1, oldColor, newColor);
                    Validate(bm, pixels, pt.X + 1, pt.Y, oldColor, newColor);
                    Validate(bm, pixels, pt.X, pt.Y + 1, oldColor, newColor);
                }
            }
        }

        //Se obtiene el punto seleccionado a escala de la imagen mostrada por el pictureBox (pb), con respecto de la longitud del pictureBox pb
        static Point SetPoint(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;

            return new Point((int) (pt.X * pX), (int) (pt.Y * pY));
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            //Cambia la acción a "rellenar"
            currentAction = 7;
        }

        private void picColorPicker_MouseClick(object sender, MouseEventArgs e)
        {
            //Se obtiene el punto seleccionado
            Point point = SetPoint(picColorPicker, e.Location);
            //Se obtiene el color del punto seleccionado por el ratón
            selectedColor = ((Bitmap)picColorPicker.Image).GetPixel(point.X, point.Y);
            //Se cambia el color de fondo de picSelectedColor al color seleccionado
            picSelectedColor.BackColor = selectedColor;
            //Se cambia el color del lápiz al color seleccionado
            pencil.Color = selectedColor;
        }

        //Rellena el área en la que el color no es el mismo que el de relleno
        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if(currentAction == 7)
            {
                Point point = SetPoint(picCanvas, e.Location);
                Fill(bm, point.X, point.Y, selectedColor);
            }
        }

        //Limpia el espacio de dibujo y lo rellena de blanco, además, define la acción a "dibujo"
        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            picCanvas.Image = bm;
            currentAction = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Instancia un SaveFileDialog para abrir el explorador de archivos para efectuar guardado de archivos
            var sfd = new SaveFileDialog();
            //Filtra los tipos de archivos que se pueden guardar
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|";

            //Abre el explorador, y espera a que la respuesta sea la selección del botón OK
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //Se crea un Rectangle desde la coordenada superior izquierda, y con el área de la imagen contenida en picCanvas
                Rectangle rect = new Rectangle(0, 0, picCanvas.Image.Width, picCanvas.Image.Height);
                //Clona el mapa de bits bm recortando el área especificada, y en el formato de bm
                Bitmap btm = bm.Clone(rect, bm.PixelFormat);
                //Guarda el mapa clonado en la dirección y el nombre, y en el formato de compresión Jpeg
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
                //Se notifica al usuario que la imagen se ha podido guardar
                MessageBox.Show("Image Saved Successfully...");
            }
        }

        //Permite modificar la anchura del lápiz según el movimiento de la rueda del ratón
        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            //Obtiene el número de pasos que ha rotada la rueda del ratón
            int delta = e.Delta;
            //Obtiene el paso a escala 1, es decir: -1 y 1, en lugar del delta real del ratín
            int newDelta = Math.Sign(delta) * (int)(delta / delta);

            //Comprueba que la suma del paso (newDelta) y el total de pasos (totalDelta) se encuentre entre el rango [1, 10]
            if(totalDelta + newDelta >= 1 && totalDelta + newDelta <= 10)
            {
                //Se suma el paso al total de pasos, esto define la nueva anchura del lápiz
                totalDelta += newDelta;
            }

            //Se define la anchura como el total de pasos (entre 1 y 10)
            pencil.Width = totalDelta;

            //Muestra en una etiqueta la anchura del lápiz
            lblPencilWidth.Text = "Pencil's width: " + pencil.Width.ToString();
            //Posiciona la etiqueta en la esquina inferior derecha de la pizarra
            lblPencilWidth.Left = this.ClientSize.Width - lblPencilWidth.Width;

            //Hace visible la etiqueta
            lblPencilWidth.Visible = true;
            //Activa el timer para que contabilice el tiempo en que puede estar visible la etiqueta
            tmrShowLabel.Enabled = true;
        }

        //Hace invisible la etiqueta de la anchura del lápiz, y detiene el timer después de 2 segundos
        private void tmrShowLabel_Tick(object sender, EventArgs e)
        {
            lblPencilWidth.Visible = false;
            tmrShowLabel.Enabled = false;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            //Cambia la acción a "dibujar elípse"
            currentAction = 3;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            //Cambia la acción a "dibujar rectángulo"
            currentAction = 4;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            //Cambia la acción a "dibujar línea"
            currentAction = 5;
        }

        //Dibuja la figura seleccionada con respecto a la acción actual al dejar de presionar el botón del ratón
        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            drawingAvailable = false;

            sX = x - cX;
            sY = y - cY;

            if(currentAction == 3)
            {
                g.DrawEllipse(pencil, cX, cY, sX, sY);
            }
            else if(currentAction == 4)
            {
                g.DrawRectangle(pencil, cX, cY, sX, sY);
            }
            else if(currentAction == 5)
            {
                g.DrawLine(pencil, cX, cY, x, y);
            }
        }

        //En cuanto el botón del ratón está presionado, la bandera de dibujo cambia a true, lo que permite dibujar en la pizarra
        //Además, calcula la posición del cursor
        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            drawingAvailable = true;
            py = e.Location;
            cX = e.X;
            cY = e.Y;
        }

        //En cuanto el cursor se mueve, si se permite dibujar, entonces se dibuja ya sea con el lápiz o el borrador en la pizarra
        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(drawingAvailable == true)
            {
                if(currentAction == 1)
                {
                    px = e.Location;
                    g.DrawLine(pencil, px, py);
                    py = px;
                }
                else if (currentAction == 2)
                {
                    px = e.Location;
                    g.DrawLine(eraser, px, py);
                    py = px;
                }
            }

            picCanvas.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }
    }
}
