using System.IO;
using System.Xml.Linq;

namespace Prim_Dijsktra_visualization
{
    public partial class Form1 : Form
    {   
        
        List<Point> points;
        List<Rectangle> rectangles;
        List<int> nodes;
        List<List<int>> graph;
        int V = 0;
        int draw_point = 0;
        int time_sleep = 200;
        Pen Black_pen;
        Pen Red_pen;
        Pen Green_pen;
        Pen Blue_pen;
        Font f;
        public Form1()
        {
            InitializeComponent();
            points = new List<Point>();
            graph = new List<List<int>>();
            rectangles = new List<Rectangle>();
            nodes = new List<int>();
            Black_pen = new Pen(Color.Black, 6);
            Red_pen = new Pen(Color.Red, 5);
            Green_pen = new Pen(Color.Lime, 5);
            Blue_pen = new Pen(Color.Blue, 5);
            f = new Font("Segoe UI", 12);
            Primbtn.Enabled = false;
            Dijsktrabtn.Enabled = false;
        }

        private void ReadGraphbtn_Click(object sender, EventArgs e)
        {
            V = Inputgraphtb.Lines.Count();
            points.Clear();
            graph.Clear();
            nodes.Clear();
            rectangles.Clear();
            try
            {
                if (V > 0)
                {
                    for (int i = 0; i < V; i++)
                    {
                        List<int> row = new List<int>();
                        string[] line = Inputgraphtb.Lines[i].Split(" ");
                        for (int j = 0; j < V; j++)
                        {
                            int num = int.Parse(line[j]);
                            if(num < 0)
                            {
                                MessageBox.Show("Graph contain negative edge!");
                                return;
                            }
                            row.Add(num);
                        }
                        graph.Add(row);
                        nodes.Add(i + 1);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Matrix is not right");
                return;
            }
            if(is_directed_graph() == true)
            {
                Directedgraphtb.Text = "True";
            }
            else
            {
                Directedgraphtb.Text = "False";
            }
            if(V!=0)
            {
                Primbtn.Enabled = true;
                Dijsktrabtn.Enabled = true;
            }
            startnode.DataSource = null;
            startnode.DataSource = nodes.ToArray();
        }

        private void PictureBoard_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = PictureBoard.CreateGraphics();
            if(draw_point < V)
            {
                Point p = new Point(e.X, e.Y);
                Rectangle rect = new Rectangle(p.X - 15, p.Y - 15, 30, 30);
                g.DrawEllipse(Black_pen, rect);
                g.FillEllipse(Brushes.White, rect);
                g.DrawString((draw_point + 1).ToString(), f, Brushes.Black, p.X - 7, p.Y - 15);
                points.Add(p);
                rectangles.Add(rect);
                draw_point++;
            }
            if(draw_point == V && draw_point != 0)
            {
                for (int i = 0; i < points.Count; i++)
                    for (int j = 0; j < points.Count; j++)
                        if (graph[i][j] != 0)
                        {
                            Black_pen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                            g.DrawLine(Black_pen, points.ElementAt(j), points.ElementAt(i));
                            int x_mid = (points.ElementAt(i).X + points.ElementAt(j).X) / 2;
                            int y_mid = (points.ElementAt(i).Y + points.ElementAt(j).Y) / 2;
                            Point mid = new Point(x_mid, y_mid);
                            g.DrawString(graph[i][j].ToString(), f, Brushes.Black, mid);
                        }
                draw_point++;
            }
        }
        bool is_directed_graph()
        {
            for(int i = 0; i < V;i++)
            {
                for(int j = 0; j < V; j++)
                {
                    if(graph[i][j] != graph[j][i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        int min_dist(int[] dist, bool[] visited)
        {
            int mindist = int.MaxValue;
            int min_idx = -1;
            for (int i = 0; i < V; i++)
            {
                if (visited[i] == false && dist[i] < mindist)
                {
                    mindist = dist[i];
                    min_idx = i;
                }
            }
            return min_idx;
        }
        string Dijsktra_Dist(int[]Dist)
        {
            string dist = "";
            for(int i = 0; i < V; i ++)
            {
                dist += "(";
                dist += i+1;
                dist += ":";
                dist += Dist[i].ToString();
                dist += ")";
                if(i != V -1)
                {
                    dist += " - ";
                }
            }
            return dist;
        }
        void Prim()
        {
            if (draw_point < V)
            {
                MessageBox.Show("You didn't draw enough points");
                return;
            }
            int[] parent = new int[V];
            int[] dist = new int[V];
            bool[] visited = new bool[V];
            Graphics g = PictureBoard.CreateGraphics();
            for (int i = 0; i < V; i++)
            {
                parent[i] = -1;
                dist[i] = int.MaxValue;
                visited[i] = false;
            }
            dist[0] = 0;
            try
            {
                for (int count = 0; count < V; count++)
                {
                    int u = min_dist(dist, visited);
                    visited[u] = true;
                    g.FillEllipse(Brushes.Red, rectangles.ElementAt(u));
                    if (parent[u] != -1)
                    {
                        g.DrawLine(Red_pen, points.ElementAt(parent[u]), points.ElementAt(u));
                    }
                    g.DrawString((u + 1).ToString(), new Font("Segoe UI", 12), Brushes.Black, points.ElementAt(u).X - 7, points.ElementAt(u).Y - 15);
                    Thread.Sleep(time_sleep);
                    for (int v = 0; v < V; v++)
                    {
                        if (visited[v] == false && graph[u][v] != 0)
                        {
                            g.DrawLine(Blue_pen, points.ElementAt(u), points.ElementAt(v));
                            if (dist[v] > graph[u][v])
                            {
                                dist[v] = graph[u][v];
                                parent[v] = u;
                            }
                            Thread.Sleep(time_sleep);
                        }
                    }
                }
                int sum = 0;
                for (int i = 0; i < V; i++)
                {
                    sum += dist[i];
                }
                Moreoutputtb.Text = "Minimun spaning Tree: " + sum.ToString();
            }
            catch
            {
                MessageBox.Show("Can's find minimun spanning tree in this graph!");
            }
        }
        void Dijsktra()
        {
            if (draw_point < V)
            {
                MessageBox.Show("Ban chua ve du diem");
                return;
            }
            int[] dist = new int[V];
            bool[] visited = new bool[V];
            int[] parent = new int[V];
            Graphics g = PictureBoard.CreateGraphics();
            for (int i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                visited[i] = false;
                parent[i] = -1;
            }
            dist[startnode.SelectedIndex] = 0;
            try
            {
                for (int i = 0; i < V; i++)
                {
                    int u = min_dist(dist, visited);
                    visited[u] = true;
                    g.FillEllipse(Brushes.Lime, rectangles.ElementAt(u));
                    g.DrawString((u + 1).ToString(), f, Brushes.Black, points.ElementAt(u).X - 7, points.ElementAt(u).Y - 15);
                    Thread.Sleep(time_sleep);
                    for (int v = 0; v < V; v++)
                    {
                        if (visited[v] == false && graph[u][v] != 0 && dist[u] != int.MaxValue && dist[v] > dist[u] + graph[u][v])
                        {
                            if (parent[v] != -1)
                            {
                                g.DrawLine(Black_pen, points.ElementAt(v), points.ElementAt(parent[v]));
                            }
                            dist[v] = dist[u] + graph[u][v];
                            parent[v] = u;
                            g.DrawLine(Green_pen, points.ElementAt(u), points.ElementAt(v));
                            Thread.Sleep(time_sleep);
                        }
                    }
                }
                Moreoutputtb.Text = Dijsktra_Dist(dist);
            }
            catch
            {
                MessageBox.Show("Can't find the sorted path to every vertices!");
            }
           
        }
        private void Primbtn_Click(object sender, EventArgs e)
        {
            Prim();
        }

        private void Dijsktrabtn_Click(object sender, EventArgs e)
        {
            Dijsktra();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            Graphics g = PictureBoard.CreateGraphics();
            g.Clear(PictureBoard.BackColor);

            for (int i = 0; i <points.Count; i++)
            {
                g.DrawEllipse(Black_pen, rectangles.ElementAt(i));
                g.FillEllipse(Brushes.White, rectangles.ElementAt(i));
            }
            for (int i = 0; i < points.Count; i++)
            {

                g.DrawString((i + 1).ToString(), f, Brushes.Black, points.ElementAt(i).X - 7, points.ElementAt(i).Y - 15);
                for (int j = 0; j < points.Count; j++)
                    if (graph[i][j] != 0)
                    {
                        Black_pen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                        g.DrawLine(Black_pen, points.ElementAt(j), points.ElementAt(i));
                        int x_mid = (points.ElementAt(i).X + points.ElementAt(j).X) / 2;
                        int y_mid = (points.ElementAt(i).Y + points.ElementAt(j).Y) / 2;
                        Point mid = new Point(x_mid, y_mid);
                        g.DrawString(graph[i][j].ToString(), f, Brushes.Black, mid);
                    }
            }
            Moreoutputtb.Clear();
        }

        private void Clearallbtn_Click(object sender, EventArgs e)
        {
            Graphics g = PictureBoard.CreateGraphics();
            g.Clear(PictureBoard.BackColor);
            points.Clear();
            rectangles.Clear();
            nodes.Clear();
            V = 0;
            draw_point = 0;
            graph.Clear();
            Moreoutputtb.Clear();
            Directedgraphtb.Clear();
            Inputgraphtb.Clear();
        }

        private void delaytime_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if (delaytime.SelectedIndex == 0)
            {
                time_sleep = 200;
                return;
            }
            time_sleep = (delaytime.SelectedIndex) * 1000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Inputgraphtb.Text = System.IO.File.ReadAllText(openFile.FileName);
                    ReadGraphbtn_Click(sender, e);
                }
                catch (IOException)
                {
                    string message = "Error opening file. \nPlease try again";
                    string title = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                }
            }
        }
    }
}