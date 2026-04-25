namespace GraphicsExample
{
    public partial class GraphicsForm : Form
    {
        public GraphicsForm()
        {
            SplashForm();
            InitializeComponent();
            DisplayPictureBox.MouseMove += DisplayPictureBox_MouseStuff;
            DisplayPictureBox.MouseDown += DisplayPictureBox_MouseStuff;
            ClearMenuItem.Click += ClearButton_Click;
            clearToolStripMenuItem.Click += ClearButton_Click;
            PenSizeComboBox.SelectedIndexChanged += PenSizeComboBox_SelectedIndexChanged;
            backgroundToolStripMenuItem.Click += backgroundToolStripMenuItem_Click;
            penToolStripMenuItem.Click += PenColor_Click;
            //populate pen size combobox
            PenSizeComboBox.Items.Add(1);
            PenSizeComboBox.Items.Add(2);
            PenSizeComboBox.Items.Add(5);
            PenSizeComboBox.Items.Add(10);
            PenSizeComboBox.Items.Add(15);
            PenSizeComboBox.Items.Add(20);
            PenSizeComboBox.SelectedIndex = 0;
        }

        private Color PenColor = Color.Black;
        private Color backGround = Color.White;
        private int penSize = 1;
        private int oldX, oldY;

        // private Color PenColor = Color.Black;
        void UpdatePenColor()
        {
            PenColorDialogue.ShowDialog();
            this.PenColor = PenColorDialogue.Color;
        }

        void UpdateBackGroundColor()
        {
            PenColorDialogue.ShowDialog();
            this.BackColor = PenColorDialogue.Color;
            DisplayPictureBox.BackColor = this.BackColor;
        }

        void UpdatePenSize()
        {
            this.penSize = int.Parse(PenSizeComboBox.SelectedItem.ToString());
        }


        //drawing button stuff--------------------------------------------------------------
        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawLine();
            DrawEllipse();
            drawRectangle();
            drawPie();
            drawText();
            DrawImage();
        }

        void DrawLine()
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Black);
            thePen.Width = 10;
            //draw the line here
            g.DrawLine(thePen, 0, 0, DisplayPictureBox.Width, DisplayPictureBox.Height);

            //free up resources
            g.Dispose();
            thePen.Dispose();

        }
        //line
        void DrawLineSegment(int newX, int newY)
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(this.PenColor);
            thePen.Width = this.penSize;
            //draw the line here
            g.DrawLine(thePen, oldX, oldY, newX, newY);
            oldX = newX;
            oldY = newY;

            //free up resources
            g.Dispose();
            thePen.Dispose();

        }
        //ellipse
        void DrawEllipse()
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Lime);
            thePen.Width = 5;

            g.DrawEllipse(thePen, 0, 0, 100, 100);

            //free up resources
            g.Dispose();
            thePen.Dispose();
        }
        //rectangle
        private void drawRectangle()
        {
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Lime);
            thePen.Width = 5;

            g.DrawRectangle(thePen, 100, 100, 200, 200);

            //free up resources
            g.Dispose();
            thePen.Dispose();
        }
        //drawPi
        private void drawPie()
        {
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Beige);
            SolidBrush theBrush = new SolidBrush(Color.Lavender);
            thePen.Width = 5;
            Rectangle bounds = new Rectangle(100, 100, 200, 200);

            g.DrawPie(thePen, bounds, 0, 6);
            g.FillPie(theBrush, bounds, 45, 130);
            g.FillPie(theBrush, bounds, 70, 20);
            g.FillPie(theBrush, bounds, 45, 210);

            //free up resources
            g.Dispose();
            thePen.Dispose();
        }
        //text
        private void drawText()
        {
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.DarkOliveGreen);
            Font theFont = new Font("Arial", 24);
            SolidBrush theBrush = new SolidBrush(Color.DarkOliveGreen);
            g.DrawString("WAAAAAA", theFont, theBrush, 0, DisplayPictureBox.Height / 5);

            //free up resources
            g.Dispose();
            thePen.Dispose();
        }
        //image
        private void DrawImage()
        {
            Graphics g = DisplayPictureBox.CreateGraphics();

            Rectangle bounds = new Rectangle(10, 10, 200, 450);
            Image TheImage = Image.FromFile("..\\..\\..\\FrodWhimsyCropped.png");
            g.DrawImage(TheImage, Bounds);
            //free up resources
            g.Dispose();

        }
        //sinewave
        private void DrawSinWave()
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(this.PenColor);
            int lastX = 0, lastY = 0, currentY = 0;
            for (int currentX = 0; currentX < 360; currentX++)
            {
                currentY = (int)(Math.Round(100 * Math.Sin(currentX)));
                g.DrawLine(thePen, lastX, lastY, currentX, currentY);
                lastX = currentX;
                lastY = currentY;

            }


            //free up resources
            g.Dispose();
            thePen.Dispose();
        }

        void DrawGrid()
        {
            DisplayPictureBox.Refresh();
            Color oldColor = this.PenColor;
            this.PenColor = Color.Gray;
            int xDiv = DisplayPictureBox.Width / 10;
            int yDiv = DisplayPictureBox.Height / 8;

            this.oldX = 0;
            this.oldY = 0;
            for (int x = 0; x < DisplayPictureBox.Width; x += xDiv)
            {
                oldX = x;
                DrawLineSegment(x, DisplayPictureBox.Height);
            }
            this.oldX = 0;
            this.oldY = 0;
            for (int y = 0; y < DisplayPictureBox.Height; y += yDiv)
            {
                oldY = y;
                DrawLineSegment(DisplayPictureBox.Width, y);
            }
            this.PenColor = oldColor;
        }


        //events-----------------------------------------------------------------------------------------------------------------------------------
        private void DisplayPictureBox_MouseStuff(object? sender, MouseEventArgs e)
        {
            this.Text = $"({e.X},{e.Y}) {e.Button}";
            switch (e.Button)
            {
                case MouseButtons.Left:
                    DrawLineSegment(e.X, e.Y);
                    break;
                case MouseButtons.Right:
                    // Save for context menu
                    break;
                case MouseButtons.Middle:
                    UpdatePenColor();
                    break;
                default:
                    //MessageBox.Show($"{e.Button}");
                    break;
            }
            //update last position on every move
            this.oldX = e.X;
            this.oldY = e.Y;
        }


        private void shake()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("..\\..\\..\\lego-yoda-death-sound-effect.wav");
            player.Play();
            Random rand = new Random();
            int shakeAmount = 100;
            int originalY = this.Location.Y;
            int originalX = this.Location.X;
            for (int i = 0; i < shakeAmount; i++)
            {
                int offsetX = rand.Next(-shakeAmount, shakeAmount);
                int offsetY = rand.Next(-shakeAmount, shakeAmount);
                this.Location = new Point(originalX + offsetX, originalY + offsetY);

                System.Threading.Thread.Sleep(50);
            }
           

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            shake();
            DisplayPictureBox.Refresh();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();

            about.Show();
            this.Hide();
        }

        private void DisplayPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void PenSizeComboBox_Click(object sender, EventArgs e)
        {

        }

        private void backgroundToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            UpdateBackGroundColor();
        }

        private void PenColor_Click(object? sender, EventArgs e)
        {
            UpdatePenColor();
        }
        private void SplashForm()
        {
            SplashForm splashForm = new SplashForm();
            splashForm.Show();
            System.Threading.Thread.Sleep(3000);
            splashForm.Close();
        }

        private void PenSizeComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdatePenSize();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
